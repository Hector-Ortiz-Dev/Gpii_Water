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
    public class RepoConsumos
    {
        public int año {get; set;}
        public int mes { get; set; }
        public int medidor { get; set; }
        public int anterior { get; set; }
        public int actual { get; set; }

        public RepoConsumos()
        {
        }

        public static void sp_reporte_consumos(DataGridView dg, string año)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<RepoConsumos>("sp_reporte_consumos",
                new
                {
                    @año = año
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

    }
}
