using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpi_Water.Conexion
{
    public class Recibo
    {
        public int id { get; set; } //Folio
        public int mes { get; set; } 
        public int año { get; set; } 
        public int medidor { get; set; }
        public float subtotal1 { get; set; }
        public float subtotal2 { get; set; }
        public float subtotal3 { get; set; }
        public float iva { get; set; }
        public float pendiente_pago { get; set; } //Pagos pendientes anteriores
        public float total_pago { get; set; } //Total a pagar
        public float pagado { get; set; } //Lo que el cliente ha pagado
        public float por_pagar { get; set; } //Solo sirve como buffer al pagar
        public int meses_adeudo { get; set; }

        public Recibo() {}
        public static void calcular_recibo(Lectura lectura)
        {
            Recibo recibo = new Recibo();
            Contrato contrato = Contrato.sp_get_contrato_single(lectura.fk_num_ref);

            float cuota_drenaje = 0.0f;
            if(contrato.tipo == "DOMESTICO")
            {
                cuota_drenaje = 110.00f;
            }
            else if(contrato.tipo == "COMERCIAL")
            {
                cuota_drenaje = 155.00f;
            }
            else if(contrato.tipo == "INDUSTRIAL")
            {
                cuota_drenaje = 188.00f;
            }

            recibo.año = lectura.año;
            recibo.mes = lectura.mes;
            recibo.medidor = contrato.medidor;
            
            Tarifa tarifa = Tarifa.sp_get_tarifas_single(contrato.zona, recibo.año, recibo.mes);

            int _año = recibo.año;
            int _mes = recibo.mes;
            if (_mes > 1)
                _mes--;
            else
            {
                _año--;
                _mes = 12;
            }
            Recibo recibo_ant = Recibo.sp_get_recibo_anterior(_año, _mes, contrato.num_ref);

            Lectura lectura_ant = Lectura.sp_get_consumo_single(_año, _mes, contrato.num_ref);
            int consumo_ant = 0;
            if (lectura_ant != null)
                consumo_ant = lectura_ant.consumo;

            recibo.pendiente_pago = 0;
            recibo.total_pago = 0;

            if (recibo_ant != null) //Si hay uno anterior
            {
                if (recibo_ant.pagado == (recibo_ant.pendiente_pago  +  recibo_ant.total_pago)) //el mes anterior esta totalmente pagado
                {
                    recibo.meses_adeudo = 0;
                    recibo.pendiente_pago = 0;
                }
                else
                { //hay deuda pendiente
                    recibo_ant.pendiente_pago = recibo_ant.total_pago + recibo_ant.pendiente_pago;
                    recibo.meses_adeudo = recibo_ant.meses_adeudo + 1;
                    recibo.pendiente_pago = recibo_ant.pendiente_pago - recibo_ant.pagado;
                }
            }
            else
            {
                recibo.meses_adeudo = 0;
                recibo.pendiente_pago = 0;
            }

            //---- CATEGORIAS ----
            Categoria categoria = Categoria.sp_get_cat(contrato.categoria);

            Rango rango = Rango.sp_get_rangos();

            //---- TARIFA ----
            if (tarifa != null)
            {
                if((lectura.consumo - consumo_ant) > rango.r1) //R1
                {
                    recibo.subtotal1 = (lectura.consumo - consumo_ant) * tarifa.basico;
                    if((lectura.consumo - consumo_ant) > rango.r2) //R2
                    {
                        recibo.subtotal1 = (lectura.consumo - consumo_ant) * tarifa.intermedio;
                        if((lectura.consumo - consumo_ant) > rango.r3) //R3
                        {
                            recibo.subtotal1 = (lectura.consumo - consumo_ant) * tarifa.excedente;
                        }
                    }
                    recibo.subtotal2 = recibo.subtotal1 * categoria.porcentaje;
                    recibo.subtotal3 = recibo.subtotal2 + cuota_drenaje;
                }
                else //Menos de R1
                {
                    recibo.subtotal1 = tarifa.cuota;
                    recibo.subtotal2 = recibo.subtotal1 * categoria.porcentaje;
                    recibo.subtotal3 = cuota_drenaje + recibo.subtotal2;
                }
                recibo.iva = recibo.subtotal3 * 0.16f;
                recibo.total_pago = recibo.subtotal3 + recibo.iva;

            } else
            {
                MessageBox.Show("Error al leer tarifas en recibo");
                return;
            }

            Recibo.sp_genera_recibo(recibo, contrato.num_ref, tarifa.id, lectura.id);
            Cliente cliente = Cliente.sp_get_cliente_single(contrato.fk_cliente);
            PDF.reciboPDF(recibo, cliente, contrato, lectura_ant, lectura, tarifa);
            MessageBox.Show("Proceso de generacion de recibos finalizado.\n" +
                "Favor de revisar los archivos en la carpeta Recibos");
            return;
        }

        public static void sp_get_recibos(DataGridView dg, int id_usuario)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Recibo>("sp_get_recibos",
                new
                {
                    @id_usuario = id_usuario
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        public static Recibo sp_get_recibo_anterior(int año, int mes, int num_ref)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Recibo>("sp_get_recibo_anterior",
                new
                {
                    @año = año,
                    @mes = mes,
                    @num_ref = num_ref
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();

            if (data.ToList().Count >= 1)
                return data.ToList()[0];
            else
                return null;
        }

        public static void sp_genera_recibo(Recibo recibo, int contrato, int tarifa, int consumo)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Recibo>("sp_genera_recibo",
                new
                {
                    @Opc = "GENERAR",
                    @id = 0,
                    @mes = recibo.mes,
                    @año = recibo.año,
                    @medidor = recibo.medidor,
                    @subtotal1 = recibo.subtotal1,
                    @subtotal2 = recibo.subtotal2,
                    @subtotal3 = recibo.subtotal3,
                    @iva = recibo.iva,
                    @meses_adeudo = recibo.meses_adeudo,
                    @pendiente_pago = recibo.pendiente_pago,
                    @total_pago = recibo.total_pago,
                    @pagado = 0,
                    @fk_contrato = contrato,
                    @fk_tarifa = tarifa,
                    @fk_consumo = consumo
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();
        }

        public static void sp_pagar_recibo(Recibo recibo)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Recibo>("sp_genera_recibo",
                new
                {
                    @Opc = "PAGAR",
                    @id = recibo.id,
                    @mes = recibo.mes,
                    @año = recibo.año,
                    @medidor = recibo.medidor,
                    @subtotal1 = recibo.subtotal1,
                    @subtotal2 = recibo.subtotal2,
                    @subtotal3 = recibo.subtotal3,
                    @iva = recibo.iva,
                    @meses_adeudo = recibo.meses_adeudo,
                    @pendiente_pago = recibo.pendiente_pago,
                    @total_pago = recibo.total_pago,
                    @pagado = recibo.pagado,
                    @fk_contrato = 0,
                    @fk_tarifa = 0,
                    @fk_consumo = 0
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();
        }
    }
}
