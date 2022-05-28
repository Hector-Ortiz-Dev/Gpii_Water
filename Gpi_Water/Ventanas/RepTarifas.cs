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
    public partial class RepTarifas : Form
    {
        public RepTarifas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RepTarifas_Load(object sender, EventArgs e)
        {
            cbAño.SelectedIndex = 0;

            RepoTarifa.sp_reporte_tarifas(dgConsumos, "");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RepoTarifa.sp_reporte_tarifas(dgConsumos, cbAño.Texts);
        }

        //Generar PDF
        private void rjButton1_Click(object sender, EventArgs e)
        {
            List<RepoTarifa> tarifas = (List<RepoTarifa>)dgConsumos.DataSource;
            if (tarifas.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }
            else
                PDF.reporte_tarifas(tarifas);
        }
    }
}
