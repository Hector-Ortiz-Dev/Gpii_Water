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
    public class Sesion
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public bool recordar { get; set; }
        public string contraseña { get; set; }
        public string tipo { get; set; }
        public string status { get; set; }

        public Sesion(string usuario, string contraseña, string tipo)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }

        public Sesion(string usuario, string contraseña, string tipo, bool recordar)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
            this.recordar = recordar;
        }

        public Sesion()
        {
        }

        public static Sesion sp_login(Sesion sesion) {
            Conexion.Connect();

            var data = Conexion.db.Query<Sesion>("sp_login",
                new
                {
                    @user = sesion.usuario,
                    @pass = sesion.contraseña,
                    @tipo_user = sesion.tipo
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            List<Sesion> sesions = data.ToList();
            if (sesions.Count >= 1)
            {
                int id = sesions[0].id;
                string usuario = sesions[0].usuario;
                string tipo = sesions[0].tipo;
                string status = sesions[0].status;

                Sesion temp = new Sesion();
                temp.id = id;
                temp.usuario = usuario;
                temp.tipo = tipo;
                temp.status = status;

                return temp;
            }

            return null;
        }

        public static Sesion sp_intentos(string sesion)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Sesion>("sp_intentos",
                new
                {
                    @user = sesion
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            List<Sesion> sesions = data.ToList();
            if (sesions.Count >= 1)
            {
                int id = sesions[0].id;
                string usuario = sesions[0].usuario;
                string tipo = sesions[0].tipo;
                string status = sesions[0].status;

                Sesion temp = new Sesion();
                temp.id = id;
                temp.usuario = usuario;
                temp.status = status;

                return temp;
            }

            return null;
        }

        public static void sp_logued(Sesion sesion)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Sesion>("sp_logued",
                new
                {
                    @user = sesion.usuario
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_recordar_pass(Sesion sesion)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Sesion>("sp_recordar_pass",
                new
                {
                    @user = sesion.usuario,
                    @pass = sesion.contraseña,
                    @tipo_user = sesion.tipo,
                    @recordar = sesion.recordar
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }
        public static string sp_get_pass(string usuario)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Sesion>("sp_get_pass",
                new
                {
                    @user = usuario,
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();

            List<Sesion> usuarios = data.ToList();

            if (usuarios.Count >= 1)
            {
                string pass = usuarios[0].contraseña;
                return pass;
            }

            return "";
        }
    }
}
