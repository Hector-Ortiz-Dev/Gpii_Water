using Gpi_Water.Conexion;
using Gpi_Water.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpi_Water.Ventanas
{
    public partial class ConHistorico : Form
    {
        public Sesion sesion;
        public ConHistorico()
        {
            InitializeComponent();
        }

        #region Funcionalidad
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Override
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            //Quitar bordes y mantener adaptacion
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void ConHistorico_Load(object sender, EventArgs e)
        {
            if(sesion.tipo == "EMPLEADO" || sesion.tipo == "ADMINISTRADOR")
                RepoHistorico.sp_reporte_historico(dgConsumos, "", "");
            if (sesion.tipo == "CLIENTE")
            {
                RepoHistorico.sp_reporte_historico_cliente(dgConsumos, sesion.id);
                groupBox.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RepoHistorico.sp_reporte_historico(dgConsumos, cbAño.Texts, txtBuscar.Texts);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<RepoHistorico> historico = (List<RepoHistorico>)dgConsumos.DataSource;
            if (historico.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }
            else
                PDF.reporte_historico(historico);
        }
    }
}
