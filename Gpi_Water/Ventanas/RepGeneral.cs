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
    public partial class RepGeneral : Form
    {
        public RepGeneral()
        {
            InitializeComponent();
        }

        private void RepGeneral_Load(object sender, EventArgs e)
        {
            RepoGeneral.sp_reporte_general(dgConsumos, "", "", "");
            cbAño.SelectedIndex = 0;
            cbMes.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RepoGeneral.sp_reporte_general(dgConsumos, cbAño.Texts, cbMes.Texts, cbTipo.Texts);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<RepoGeneral> general = (List<RepoGeneral>)dgConsumos.DataSource;
            if (general.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }
            else
                PDF.reporte_general(general);
        }
    }
}
