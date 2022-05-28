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
    public class Cliente
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public DateTime f_nacimiento { get; set; }
        public string genero { get; set; }
        public string email { get; set; }
        public string curp { get; set; }
        public string rfc { get; set; }
        public DateTime f_alta_mod { get; set; }
        public string institucion { get; set; }
        public bool per_moral { get; set; }
        public string status { get; set; }

        public Cliente() { }

        public Cliente(int id)
        {
            this.id = id;
            this.f_nacimiento = DateTime.Now;
        }

        public Cliente(string usuario, string contraseña, string nombre, string apellido_p, string apellido_m, DateTime f_nacimiento, string genero, string email, string curp, string rfc, string institucion, bool per_moral)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.nombre = nombre.ToUpper();
            this.apellido_p = apellido_p.ToUpper();
            this.apellido_m = apellido_m.ToUpper();
            this.f_nacimiento = f_nacimiento;
            this.genero = genero;
            this.email = email;
            this.curp = curp.ToUpper();
            this.rfc = rfc.ToUpper();
            this.institucion = institucion.ToUpper();
            this.per_moral = per_moral;
        }

        public static void sp_get_clientes(DataGridView dg, string buscar)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Cliente>("sp_get_clientes",
                new { buscar = buscar },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        public static void sp_get_clientes_cb(RJCodeAdvance.RJControls.RJComboBox combo, string buscar)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Cliente>("sp_get_clientes_cb",
                new { buscar = buscar},
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            combo.DataSource = data;
            combo.ValueMember = "id";
            combo.DisplayMember = "nombre";
        }

        public static void sp_alta_cliente_contrato(Cliente cliente, Contrato contrato)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Cliente>("sp_alta_cliente_contrato",
                new
                {
                    //Usuario
                    @user = cliente.usuario,
                    @pass = cliente.contraseña,
                    @nombre = cliente.nombre,
                    @apellido_p = cliente.apellido_p,
                    @apellido_m = cliente.apellido_m,
                    @f_nacimiento = cliente.f_nacimiento,
                    @genero = cliente.genero,

                    //Cliente
                    @email = cliente.email,
                    @curp = cliente.curp,
                    @per_moral = cliente.per_moral,
                    @institucion = cliente.institucion,
                    @rfc = cliente.rfc,

                    //Contrato
                    @medidor = contrato.medidor,
                    @tipo = contrato.tipo,
                    @categoria = contrato.categoria,
                    @municipio = contrato.municipio,
                    @cod_postal = contrato.cod_postal,
                    @colonia = contrato.colonia,
                    @calle = contrato.calle,
                    @num_ext = contrato.num_ext
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_modificar_cliente(Cliente cliente)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Cliente>("sp_gestion_cliente",
                new
                {
                    @Opc = "MODIFICAR",
                    @id = cliente.id,
                    @user = cliente.usuario,
                    @pass = cliente.contraseña,
                    @nombre = cliente.nombre,
                    @apellido_p = cliente.apellido_p,
                    @apellido_m = cliente.apellido_m,
                    @f_nacimiento = cliente.f_nacimiento,
                    @genero = cliente.genero,
                    @email = cliente.email,
                    @curp = cliente.curp,
                    @per_moral = cliente.per_moral,
                    @institucion = cliente.institucion,
                    @rfc = cliente.rfc
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_baja_cliente(Cliente cliente)
        {
            var data = Conexion.db.Query<Cliente>("sp_gestion_cliente",
                new
                {
                    @id = cliente.id,
                    @user = cliente.usuario,
                    @pass = cliente.contraseña,
                    @nombre = cliente.nombre,
                    @apellido_p = cliente.apellido_p,
                    @apellido_m = cliente.apellido_m,
                    @f_nacimiento = cliente.f_nacimiento,
                    @genero = cliente.genero,
                    @email = cliente.email,
                    @curp = cliente.curp,
                    @per_moral = cliente.per_moral,
                    @institucion = cliente.institucion,
                    @rfc = cliente.rfc,
                    @Opc = "ELIMINAR"
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();
        }

        public static void sp_desbanear(Cliente cliente)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Cliente>("sp_desbanear",
                new
                {
                    @id = cliente.id,
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static List<string> get_usuarios()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<string>("sp_get_usuarios",
                new {  },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
            
            return data.ToList();
        }

        public static List<string> get_curps()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<string>("sp_get_curps",
                new { },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static List<string> get_rfcs()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<string>("sp_get_rfcs",
                new { },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static void sp_get_cliente_contrato_cb(RJCodeAdvance.RJControls.RJComboBox combo, string buscar)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Cliente>("sp_get_cliente_contrato_cb",
                new { buscar = buscar },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            combo.DataSource = data;
            combo.DisplayMember = "nombre";
        }

        public static Cliente sp_get_cliente_single(int id_cliente)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Cliente>("sp_get_cliente_single",
                new {
                    @id_cliente = id_cliente
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList()[0];
        }
    }
}
