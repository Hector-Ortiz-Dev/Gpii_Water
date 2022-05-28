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
    public class Lectura
    {
        public int id { get; set; }
        public int consumo { get; set; }
        public int mes { get; set; }
        public int año { get; set; }
        public string tipo { get; set; }
        public int fk_num_ref { get; set; }

        public Lectura() { }

        public Lectura(int consumo, int mes, int año, int fk_num_ref)
        {
            this.consumo = consumo;
            this.mes = mes;
            this.año = año;
            this.fk_num_ref = fk_num_ref;
        }

        public Lectura(int año)
        {
            this.año = año;
        }

        public static void sp_get_consumos(DataGridView dg, string año, string num_ref)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Lectura>("sp_get_consumos",
                new
                {
                    año = año,
                    num_ref = num_ref
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        public static bool sp_get_consumos_valid(Lectura consumo)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Lectura>("sp_get_consumos_valid",
                new
                {
                    @mes = consumo.mes,
                    @año = consumo.año,
                    @num_ref = consumo.fk_num_ref
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();

            if (data.ToList().Count >= 1)
                return true;
            else
                return false;
        }

        public static void sp_agregar_consumo(Lectura consumo)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Lectura>("sp_gestion_consumo",
                new
                {
                    @Opc = "AGREGAR",
                    @id = 0,
                    @consumo = consumo.consumo,
                    @mes = consumo.mes,
                    @año = consumo.año,
                    @fk_num_ref = consumo.fk_num_ref 
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static List<Lectura> sp_get_consumo_recibo(int año, int mes, string tipo)
        {
            try
            {
                Conexion.Connect();

                var data = Conexion.db.Query<Lectura>("sp_get_consumo_recibo",
                    new
                    {
                        @año = año,
                        @mes = mes,
                        @tipo = tipo
                    },
                    commandType: CommandType.StoredProcedure); ;

                Conexion.Disconnect();

                if (data.ToList().Count >= 1)
                    return data.ToList();
                else
                    return null;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Lectura sp_get_consumo_single(int año, int mes, int num_ref)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Lectura>("sp_get_consumos_valid",
                new
                {
                    @mes = mes,
                    @año = año,
                    @num_ref = num_ref
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();

            if (data.ToList().Count >= 1)
                return data.ToList()[0];
            else
                return null;
        }
    }
}
