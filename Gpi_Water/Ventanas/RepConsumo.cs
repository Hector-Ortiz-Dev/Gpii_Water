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
    public partial class RepConsumo : Form
    {
        public RepConsumo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RepConsumo_Load(object sender, EventArgs e)
        {
            cbAño.SelectedIndex = 0;

            RepoConsumos.sp_reporte_consumos(dgConsumos, "");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RepoConsumos.sp_reporte_consumos(dgConsumos, cbAño.Texts);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<RepoConsumos> consumos = (List<RepoConsumos>)dgConsumos.DataSource;
            if (consumos.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }
            else
                PDF.reporte_consumos(consumos);
        }
    }
}
