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
    public partial class AgregarCliente : Form
    {
        private int borderSize = 2;
        Valid v = new Valid();

        #region errores
        //Usuario
        bool errorUsuario = true;
        bool errorContra = true;
        bool errorNombre = true;
        bool errorApellidoP = true;
        bool errorApellidoM = true;
        bool errorFecha = true;
        bool errorGenero = true;
        bool errorEmail = true;
        bool errorCurp = true;
        bool errorRfc = true;
        bool errorInstitucion = true;
        //Contrato
        bool errorTipo = true;
        bool errorMunicipio = true;
        bool errorColonia = true;
        bool errorCalle = true;
        bool errorNum = true;
        bool errorCodPos = true;
        bool errorMedidor = true;
        bool errorCategoria = true;
#endregion

        public AgregarCliente()
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
            Municipio.sp_get_municipios_cb(cbMunicipio);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorUsuario = Valid.UsuarioCliente(errorProv, txtUsuario);
                errorContra = Valid.nombre(errorProv, txtContrasena);
                errorNombre = Valid.nombre(errorProv, txtNombre);
                errorApellidoP = Valid.nombre(errorProv, txtApellidoP);
                errorApellidoM = Valid.nombre(errorProv, txtApellidoM);
                errorGenero = Valid.ComboValid(errorProv, cbGenero);
                errorEmail = Valid.email(errorProv, txtEmail);
                errorCurp = Valid.CurpCliente(errorProv, txtCurp);
                errorRfc = Valid.RfcCliente(errorProv, txtRfc);
                errorInstitucion = Valid.nombre(errorProv, txtInstitucion);
                errorTipo = Valid.ComboValid(errorProv, cbTipo);
                errorMunicipio = Valid.ComboValid(errorProv, cbMunicipio);
                errorColonia = Valid.nombre(errorProv, txtColonia);
                errorCalle = Valid.nombre(errorProv, txtCalle);
                errorNum = Valid.nombre(errorProv, txtNumero);
                errorCodPos = Valid.nombre(errorProv, txtCodPos);
                errorMedidor = Valid.nombre(errorProv, txtMedidor);
                errorCategoria = Valid.ComboValid(errorProv, cbCategoria);

                if (errorUsuario || errorContra || errorNombre || errorApellidoP || errorApellidoM ||
                    errorGenero || errorEmail || errorCurp || errorRfc ||
                    errorTipo || errorMunicipio || errorColonia || errorCalle || errorNum || errorCodPos ||
                    errorMedidor || errorCategoria)
                {
                    MessageBox.Show("Verificar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (chEsMoral.Checked) //Si es moral
                    {
                        //Si txt de Institucion es vacio
                        errorInstitucion = Valid.nombre(errorProv, txtInstitucion);
                        if (errorInstitucion)
                        {
                            MessageBox.Show("Verificar los campos.", "Error");
                            return;
                        }
                    }
                    else if (chEsMoral.Checked == false) //Si es persona fisica
                    {
                        //Si es menor de edad
                        errorFecha = Valid.mayorEdad(errorProv, dpFechaNac);
                        if(errorFecha)
                        {
                            MessageBox.Show("Verificar los campos.", "Error");
                            return;
                        }
                    }

                    //Instancias de cliente y contrato
                    Cliente cliente = new Cliente(
                        txtUsuario.Texts,
                        txtContrasena.Texts,
                        txtNombre.Texts,
                        txtApellidoP.Texts,
                        txtApellidoM.Texts,
                        dpFechaNac.Value,
                        cbGenero.Texts,
                        txtEmail.Texts,
                        txtCurp.Texts,
                        txtRfc.Texts,
                        txtInstitucion.Texts,
                        chEsMoral.Checked
                        );
                    Contrato contrato = new Contrato(
                        int.Parse(txtMedidor.Texts),
                        cbTipo.Texts,
                        cbCategoria.Texts,
                        cbMunicipio.Texts,
                        int.Parse(txtCodPos.Texts),
                        txtColonia.Texts,
                        txtCalle.Texts,
                        int.Parse(txtNumero.Texts)
                        );

                    Cliente.sp_alta_cliente_contrato(cliente, contrato);

                    MessageBox.Show("El usuario " + cliente.usuario + " ha sido registrado", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
