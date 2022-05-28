using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpi_Water.Conexion
{
    public class Rango
    {
        public int cuota { get; set; }
        public int r1 { get; set; }
        public int r2 { get; set; }
        public int r3 { get; set; }

        public Rango() { }

        public static Rango sp_get_rangos()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Rango>("sp_get_rangos",
                new
                {
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();

            if (data.ToList().Count >= 1)
                return data.ToList()[0];
            else
                return null;
        }
    }
}
