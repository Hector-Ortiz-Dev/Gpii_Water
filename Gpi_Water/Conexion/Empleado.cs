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
    public class Empleado
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public DateTime f_nacimiento { get; set; }
        public DateTime f_alta_mod { get; set; }
        public string genero { get; set; }
        public string status { get; set; }
        public string domicilio { get; set; }

        public Empleado() { }

        public Empleado(int id, string usuario, string contraseña, string nombre, string apellido_p, string apellido_m, DateTime f_nacimiento, string genero, string domicilio)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.nombre = nombre.ToUpper();
            this.apellido_p = apellido_p.ToUpper();
            this.apellido_m = apellido_m.ToUpper();
            this.f_nacimiento = f_nacimiento;
            this.genero = genero;
            this.domicilio = domicilio.ToUpper();
        }

        public Empleado(int id)
        {
            this.id = id;
            this.f_nacimiento = DateTime.Now;
        }

        public static void sp_get_empleados(DataGridView dg, string buscar)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Empleado>("sp_get_empleados",
                new { buscar = buscar },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        public static void sp_agregar_empleado(Empleado empleado)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Empleado>("sp_gestion_empleado",
                new
                {
                    @id = empleado.id,
                    @user = empleado.usuario,
                    @pass = empleado.contraseña,
                    @nombre = empleado.nombre,
                    @apellido_p = empleado.apellido_p,
                    @apellido_m = empleado.apellido_m,
                    @f_nacimiento = empleado.f_nacimiento,
                    @genero = empleado.genero,
                    @domicilio = empleado.domicilio,
                    @Opc = "AGREGAR"
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_modificar_empleado(Empleado empleado)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Empleado>("sp_gestion_empleado",
                new
                {
                    @id = empleado.id,
                    @user = empleado.usuario,
                    @pass = empleado.contraseña,
                    @nombre = empleado.nombre,
                    @apellido_p = empleado.apellido_p,
                    @apellido_m = empleado.apellido_m,
                    @f_nacimiento = empleado.f_nacimiento,
                    @genero = empleado.genero,
                    @domicilio = empleado.domicilio,
                    @Opc = "MODIFICAR"
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_baja_empleado(Empleado empleado)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Empleado>("sp_gestion_empleado",
                new
                {
                    @id = empleado.id,
                    @user = empleado.usuario,
                    @pass = empleado.contraseña,
                    @nombre = empleado.nombre,
                    @apellido_p = empleado.apellido_p,
                    @apellido_m = empleado.apellido_m,
                    @f_nacimiento = empleado.f_nacimiento,
                    @genero = empleado.genero,
                    @domicilio = empleado.domicilio,
                    @Opc = "ELIMINAR"
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_desbanear(Empleado empleado)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Empleado>("sp_desbanear",
                new
                {
                    @id = empleado.id,
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }


        public static List<string> get_usuarios()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<string>("sp_get_usuarios",
                new { },
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
    }
}
