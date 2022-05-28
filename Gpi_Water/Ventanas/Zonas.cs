using Gpi_Water.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpi_Water.Ventanas
{
    public partial class Zonas : Form
    {
        string municipio_name = "";

        int sel_muni = -1;
        int sel_zona = -1;
        int id_zona = -1;
        int id_municipio = -1;

        public Zonas()
        {
            InitializeComponent();
        }

        private void Zonas_Load(object sender, EventArgs e)
        {
            sel_muni = -1;
            sel_zona = -1;
            id_municipio = -1;
            id_zona = -1;

            Municipio.sp_get_municipios(dgMunicipios);
            Zona_v2.sp_get_zonas_v2(dgZonas);
            Zona_v2.sp_get_zonas_v2_c(cbZonas);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgMunicipios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_muni = e.RowIndex;

            if (sel_muni < 0)
                return;

            id_municipio = int.Parse(dgMunicipios.Rows[sel_muni].Cells["id_muni"].Value.ToString());
            municipio_name = dgMunicipios.Rows[sel_muni].Cells["municipio"].Value.ToString();
        }

        private void dgZonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_zona = e.RowIndex;

            if (sel_zona < 0)
                return;
            
            id_zona = int.Parse(dgZonas.Rows[sel_zona].Cells["id"].Value.ToString());

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (id_municipio != -1)
            {
                Municipio.sp_gestion_municipio(id_municipio.ToString(), municipio_name, cbZonas.Texts);
                MessageBox.Show("Zona cambiada");
                Zonas_Load(sender, e);
            }
            else
                MessageBox.Show("Selecciona un municipio");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtZona.Texts != "")
            {
                try
                {
                    Zona_v2.sp_gestion_zona("AGREGAR", 0, txtZona.Texts);
                    MessageBox.Show("Zona agregada");
                    Zonas_Load(sender, e);
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    MessageBox.Show("Ya existe una zona con este nombre");
                }
            }
            else
                MessageBox.Show("Ingresa un nombre para la zona");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtZona.Texts != "")
            {
                if (id_zona != -1)
                {
                    try
                    {
                        Zona_v2.sp_gestion_zona("MODIFICAR", id_zona, txtZona.Texts);
                        MessageBox.Show("Zona modificada");
                        Zonas_Load(sender, e);
                    } catch(Exception ex)
                    {
                        ex.Message.ToString();
                        MessageBox.Show("Ya existe una zona con este nombre");
                    }
                }
                else
                    MessageBox.Show("Selecciona una zona");
            }
            else
                MessageBox.Show("Ingresa un nombre para la zona");
        }
    }
}
