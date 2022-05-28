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

namespace Gpi_Water
{
    public partial class Login : Form
    {
        private int borderSize = 2;

        //Constructor
        public Login()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //Tamano del brode
            this.BackColor = Color.FromArgb(98, 102, 244); //Color del borde
        }

        #region funcionamiento del form
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Arrastrar ventana desde el panel
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Texts == "" || txtContra.Texts == "" || cbTipo.Texts == "")
                MessageBox.Show("Llena todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Sesion user = new Sesion(txtUsuario.Texts, txtContra.Texts, cbTipo.Texts);

                //user.usuario = txtUsuario.Texts; //text
                //user.contraseña = txtUsuario.Texts; //text
                //user.tipo = cbTipo.Texts; //combo

                user = Sesion.sp_login(user);

                if (user == null)
                {
                    user = Sesion.sp_intentos(txtUsuario.Texts);
                    if (user == null)
                    {
                        MessageBox.Show("Datos incorrectos, favor de verificar.", "Error");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El usuario " + user.usuario + " ha sido baneado.", "Error");
                        return;
                    }
                }
                else if (user.status == "BANEADO")
                {
                    MessageBox.Show("Este usuario se encuentra baneado, favor de reportarse con la empresa para resolver problemas.", "Error");
                    return;
                }
                else if (user.status == "BAJA")
                {
                    MessageBox.Show("Este usuario se encuentra dado de baja, favor de reportarse con la empresa para resolver problemas.", "Error");
                    return;
                }
                else
                {
                    Sesion.sp_logued(user);
                    this.Hide();
                    Principal wnd = new Principal();
                    wnd.sesion = user;
                    wnd.Show();
                }
            }
        }
        private void btnRevelar_Click(object sender, EventArgs e)
        {

        }

        private void checkRecordar_CheckedChanged(object sender, EventArgs e)
        {
                Sesion user = new Sesion(txtUsuario.Texts, txtUsuario.Texts, cbTipo.Texts, checkRecordar.Checked);
            
                Sesion.sp_recordar_pass(user);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtContra.Texts = Sesion.sp_get_pass(txtUsuario.Texts);
            }
        }

        private void btnRevelar_Click_1(object sender, EventArgs e)
        {
        }
    }
}
