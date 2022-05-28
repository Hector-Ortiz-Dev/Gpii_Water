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
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public string status { get; set; }

        public Usuario() { }

        public Usuario(int id)
        {
            this.id = id;
        }

        public static void sp_get_baneos(DataGridView dg, string buscar, string filtro)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Usuario>("sp_get_baneos",
                new
                { 
                    @buscar = buscar,
                    @filtro = filtro
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        public static void sp_desbanear(Usuario usuario)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Usuario>("sp_desbanear",
                new
                {
                    @id = usuario.id,
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }
    }
}
