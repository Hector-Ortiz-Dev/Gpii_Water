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
    public partial class ModificarContrato : Form
    {
        public Contrato contrato;
        private int borderSize = 2;
        Valid v = new Valid();

        bool errorTipo = true;
        bool errorMunicipio = true;
        bool errorColonia = true;
        bool errorCalle = true;
        bool errorNumero = true;
        bool errorCodPos = true;
        bool errorMedidor = true;
        bool errorCategoria = true;

        public ModificarContrato()
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

        private void AgregarContrato_Load(object sender, EventArgs e)
        {
            Municipio.sp_get_municipios_cb(cbMunicipio);

            //Llenar elementos
            cbTipo.Texts = contrato.tipo;
            cbMunicipio.Texts = contrato.municipio;
            txtColonia.Texts = contrato.colonia;
            txtCalle.Texts = contrato.calle;
            txtNumero.Texts = contrato.num_ext.ToString();
            txtCodPos.Texts = contrato.cod_postal.ToString();
            txtMedidor.Texts = contrato.medidor.ToString();
            cbCategoria.Texts = contrato.categoria.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                errorTipo = Valid.ComboValid(errorProv, cbTipo);
                errorMunicipio = Valid.ComboValid(errorProv, cbMunicipio);
                errorColonia = Valid.nombre(errorProv, txtColonia);
                errorCalle = Valid.nombre(errorProv, txtCalle);
                errorNumero = Valid.nombre(errorProv, txtNumero);
                errorCodPos = Valid.nombre(errorProv, txtCodPos);
                errorMedidor = Valid.nombre(errorProv, txtMedidor);
                errorCategoria = Valid.ComboValid(errorProv, cbCategoria);

                if (errorTipo || errorMunicipio || errorColonia || errorCalle || errorNumero ||
                    errorCodPos || errorMedidor || errorCategoria)
                {
                    MessageBox.Show("Verificar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    //Crear objeto contrato
                    contrato.medidor = int.Parse(txtMedidor.Texts);
                    contrato.tipo = cbTipo.Texts;
                    contrato.categoria = cbCategoria.Texts;
                    contrato.municipio = cbMunicipio.Texts;
                    contrato.cod_postal = int.Parse(txtCodPos.Texts);
                    contrato.colonia = txtColonia.Texts;
                    contrato.calle = txtCalle.Texts;
                    contrato.num_ext = int.Parse(txtNumero.Texts);

                    Contrato.sp_modificar_contrato(contrato);

                    MessageBox.Show("El contrato se ha modificado", "Contrato modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Validaciones para que solo permita ingresar numeros
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
