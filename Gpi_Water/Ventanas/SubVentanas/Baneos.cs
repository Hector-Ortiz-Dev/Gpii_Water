using Gpi_Water.Conexion;
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
    public partial class Baneos : Form
    {
        int index_row = -1;
        public Sesion sesion;

        public Baneos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Baneos_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Clear();
            if (sesion.tipo == "EMPLEADO")
            {
                cbTipo.Items.Add("SELECCIONAR");
                cbTipo.Items.Add("CLIENTES");

                Usuario.sp_get_baneos(dgBaneos, "", "CLIENTES");
            }
            else if (sesion.tipo == "ADMINISTRADOR")
            {
                cbTipo.Items.Add("SELECCIONAR");
                cbTipo.Items.Add("EMPLEADOS");
                cbTipo.Items.Add("CLIENTES");

                Usuario.sp_get_baneos(dgBaneos, "", cbTipo.Texts);
            }
            else
                MessageBox.Show("Problema al identificar el tipo de usuario");

            cbTipo.SelectedIndex = 0;
        }

        private void txtNombre__TextChanged(object sender, EventArgs e)
        {
            Usuario.sp_get_baneos(dgBaneos, txtNombre.Texts, cbTipo.Texts);
        }
        private void cbTipo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario.sp_get_baneos(dgBaneos, txtNombre.Texts, cbTipo.Texts);
        }

        private void btnDesbanear_Click(object sender, EventArgs e)
        {
            if (index_row == -1)
                return;

            Usuario usuario = new Usuario(index_row);

            try
            {
                Usuario.sp_desbanear(usuario);

                MessageBox.Show("El usuario ha sido desbaneado.");

                Baneos_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgBaneos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index_row = e.RowIndex;

                if (index_row < 0)
                    return;
                index_row = int.Parse(dgBaneos.Rows[index_row].Cells["id"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
