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
    public partial class ModificarCliente : Form
    {
        private int borderSize = 2;
        Valid v = new Valid();

        public Cliente cliente;

        #region errores
        //Usuario
        bool errorNombre = true;
        bool errorApellidoP = true;
        bool errorApellidoM = true;
        bool errorFecha = true;
        bool errorGenero = true;
        bool errorEmail = true;
        bool errorCurp = true;
        bool errorRfc = true;
        bool errorInstitucion = true;
        #endregion

        public ModificarCliente()
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            if (cliente.per_moral == true)
            {
                chEsMoral.Checked = true;
            }
            else if (cliente.per_moral == false)
            {
                chEsMoral.Checked = false;
            }
            else
                MessageBox.Show("Error al momento de identificar per_moral");

            lblUsuario.Text = cliente.usuario;
            txtNombre.Texts = cliente.nombre;
            txtApellidoP.Texts = cliente.apellido_p;
            txtApellidoM.Texts = cliente.apellido_m;
            dpFechaNac.Text = cliente.f_nacimiento.ToString();
            cbGenero.Texts = cliente.genero;
            txtEmail.Texts = cliente.email;
            txtCurp.Texts = cliente.curp;
            txtRfc.Texts = cliente.rfc;

            if (chEsMoral.Checked == true) //Si es persona moral
            {
                lblInstitucion.Visible = true;
                txtInstitucion.Visible = true;
                gpUsuario.Text = "Datos de la empresa y contacto";
                lblFecha.Text = "Fecha de constitucion";
                txtInstitucion.Texts = cliente.institucion;
            }
            else //Si es persona fisica
            {
                lblInstitucion.Visible = false;
                txtInstitucion.Visible = false;
                gpUsuario.Text = "Datos de usuario";
                lblFecha.Text = "Fecha de nacimiento";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chEsMoral_CheckedChanged(object sender, EventArgs e)
        {
            if(chEsMoral.Checked == true)
            {
                lblInstitucion.Visible = true;
                txtInstitucion.Visible = true;
                gpUsuario.Text = "Datos de la empresa y contacto";
                lblFecha.Text = "Fecha de constitucion";
            }
            else
            {
                lblInstitucion.Visible = false;
                txtInstitucion.Visible = false;
                gpUsuario.Text = "Datos de usuario";
                lblFecha.Text = "Fecha de nacimiento";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                errorNombre = Valid.nombre(errorProv, txtNombre);
                errorApellidoP = Valid.nombre(errorProv, txtApellidoP);
                errorApellidoM = Valid.nombre(errorProv, txtApellidoM);
                errorGenero = Valid.ComboValid(errorProv, cbGenero);
                errorEmail = Valid.email(errorProv, txtEmail);
                errorCurp = Valid.ModCurpCliente(errorProv, txtCurp);
                errorRfc = Valid.ModRfcCliente(errorProv, txtRfc);
                errorInstitucion = Valid.nombre(errorProv, txtInstitucion);

                if (errorNombre || errorApellidoP || errorApellidoM ||
                    errorGenero || errorEmail || errorCurp || errorRfc)
                {
                    MessageBox.Show("Verificar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (cliente.per_moral == true) //Si es moral
                    {
                        //Si txt de Institucion es vacio
                        errorInstitucion = Valid.nombre(errorProv, txtInstitucion);
                        if (errorInstitucion)
                        {
                            MessageBox.Show("Verificar los campos.", "Error");
                            return;
                        }
                    }
                    else if (cliente.per_moral == false) //Si es persona fisica
                    {
                        //Si es menor de edad
                        errorFecha = Valid.mayorEdad(errorProv, dpFechaNac);
                        if(errorFecha)
                        {
                            MessageBox.Show("Verificar los campos.", "Error");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al identificar per_moral en el boton", "Error");
                        return;
                    }

                    //Instancias de cliente y contrato
                    cliente.nombre = txtNombre.Texts;
                    cliente.apellido_p = txtApellidoP.Texts;
                    cliente.apellido_m = txtApellidoM.Texts;
                    cliente.f_nacimiento = dpFechaNac.Value;
                    cliente.genero = cbGenero.Texts;
                    cliente.email = txtEmail.Texts;
                    cliente.curp = txtCurp.Texts;
                    cliente.rfc = txtRfc.Texts;
                    cliente.institucion = txtInstitucion.Texts;

                    //Ejectuar procedure
                    try
                    {
                        Cliente.sp_modificar_cliente(cliente);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                    MessageBox.Show("El usuario " + cliente.usuario + " ha sido modificado", "Usuario modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
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

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.AlfaNum(e);
        }

        private void txtRfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.AlfaNum(e);

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Num(e);
        }

        private void txtCodPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Num(e);
        }

        private void txtMedidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Num(e);
        }
    }
}
