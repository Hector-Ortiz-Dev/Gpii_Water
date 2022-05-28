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
    public class Municipio
    {

        public int id { get; set; }
        public string municipio { get; set; }
        public string zona { get; set; }

        public Municipio() { }

        //Llenar dg de municipios
        public static void sp_get_municipios(DataGridView dg)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Municipio>("sp_get_municipios",
                new { },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        //Llenar comboBox de municipios
        public static void sp_get_municipios_cb(RJCodeAdvance.RJControls.RJComboBox combo)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Municipio>("sp_get_municipios",
                new { },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            combo.DisplayMember = "municipio";
            combo.DataSource = data;
        }

        //Cambiar la zona del municipio seleccionado
        public static void sp_gestion_municipio(string id, string municipio, string zona)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Municipio>("sp_gestion_municipio",
                new {
                    @Opc = "MODIFICAR",
                    @id = id,
                    @municipio = municipio,
                    @zona =zona
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }
    }
}
