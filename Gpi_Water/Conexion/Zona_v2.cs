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
    public class Zona_v2
    {
        public int id { get; set; }
        public string zona { get; set; }
        public Zona_v2() { }

        //Para llenar el dg de Zonas
        public static void sp_get_zonas_v2(DataGridView dg)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Zona_v2>("sp_get_zonas_v2",
                new { },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        //Obtener municipios para el cb
        public static void sp_get_zonas_v2_c(RJCodeAdvance.RJControls.RJComboBox combo)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Zona_v2>("sp_get_zonas_v2",
                new { },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            combo.DisplayMember = "zona";
            combo.DataSource = data;
        }

        //Agregar y modificar zonas
        public static void sp_gestion_zona(string opc, int id, string nombre)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Zona_v2>("sp_gestion_zona",
                new {
                    @Opc = opc,
                    @id = id,
                    @nombre = nombre
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }
    }
}
