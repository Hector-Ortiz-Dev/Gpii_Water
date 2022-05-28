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
    public class RepoGeneral
    {
        public int año {get; set;}
        public int mes { get; set; }
        public string zona { get; set; }
        public string tipo { get; set; }
        public float pagado { get; set; }
        public float pendiente_pago { get; set; }

        public RepoGeneral()
        {
        }

        public static void sp_reporte_general(DataGridView dg, string año, string mes, string tipo)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<RepoGeneral>("sp_reporte_general",
                new
                {
                    @año = año,
                    @mes = mes,
                    @tipo = tipo
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

    }
}
