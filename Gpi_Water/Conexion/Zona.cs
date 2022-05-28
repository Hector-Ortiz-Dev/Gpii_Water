using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpi_Water.Conexion
{
    class Zona
    {
        public string municipio { get; set; }
        public string zona { get; set; }
        public Zona() { }

        public static void sp_get_zonas(RJCodeAdvance.RJControls.RJComboBox combo)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Zona>("sp_get_zonas",
                new { },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            combo.ValueMember = "zona";
            combo.DisplayMember = "municipio";
            combo.DataSource = data;
        }
    }
}