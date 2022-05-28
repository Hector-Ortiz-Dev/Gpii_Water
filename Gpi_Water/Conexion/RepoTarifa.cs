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
    public class RepoTarifa
    {
        public int año {get; set;}
        public int mes { get; set; }
        public int zona { get; set; }
        public int cuota { get; set; }
        public string tipo { get; set; }
        public int basico { get; set; }
        public int intermedio { get; set; }
        public int excedente { get; set; }

        public RepoTarifa()
        {
        }

        public static void sp_reporte_tarifas(DataGridView dg, string año)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<RepoTarifa>("sp_reporte_tarifas",
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
