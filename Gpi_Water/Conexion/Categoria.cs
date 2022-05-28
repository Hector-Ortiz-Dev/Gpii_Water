using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpi_Water.Conexion
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float porcentaje { get; set; }

        public Categoria() { }

        public static Categoria sp_get_cat(string cat)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Categoria>("sp_get_cat",
                new
                {
                    @nombre = cat
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            if (data.ToList().Count >= 1)
                return data.ToList()[0];
            else
                return null;
        }
    }
}
