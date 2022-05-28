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

namespace Gpi_Water.Ventanas.SubVentanas
{
    public partial class AgregarEmpleado : Form
    {
        Valid v = new Valid();
        private int borderSize = 2;

        bool errorUsuario = true;
        bool errorContra = true;
        bool errorNombre = true;
        bool errorApP = true;
        bool errorApM = true;
        bool errorFecha = true;
        bool errorDomicilio = true;
        bool errorGenero = true;

        public AgregarEmpleado()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //Tamano del brode
            this.BackColor = Color.FromArgb(98, 102, 244); //Color del borde
        }

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
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorUsuario = Valid.UsuarioEmpleado(errorProv, txtUsuario);
                errorContra = Valid.nombre(errorProv, txtContrasena);
                errorNombre = Valid.nombre(errorProv, txtNombre);
                errorApP = Valid.nombre(errorProv, txtApellidoP);
                errorApM = Valid.nombre(errorProv, txtApellidoM);
                errorFecha = Valid.mayorEdad(errorProv, dpFechaNac);
                errorDomicilio = Valid.nombre(errorProv, txtDomicilio);
                errorGenero = Valid.ComboValid(errorProv, cbGenero);

                if (errorUsuario || errorContra || errorNombre || errorApP || errorApM || errorFecha || errorDomicilio || errorGenero)
                {
                    MessageBox.Show("Verificar los campos.", "Error");
                    return;
                }
                else
                {
                    Empleado empleado = new Empleado(0, txtUsuario.Texts, txtContrasena.Texts, txtNombre.Texts, txtApellidoP.Texts, txtApellidoM.Texts, dpFechaNac.Value, cbGenero.Texts, txtDomicilio.Texts);

                    Empleado.sp_agregar_empleado(empleado);

                    MessageBox.Show("El usuario " + empleado.usuario + " ha sido registrado", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                    this.Close();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetNum(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }
    }
}
