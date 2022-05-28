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
    public partial class ModificarTarifa : Form
    {
        Valid v = new Valid();
        private int borderSize = 2;
        public Tarifa tarifa;

        bool errorBasico = true;
        bool errorIntermedio = true;
        bool errorExcedente = true;
        bool errorCuota = true;

        public ModificarTarifa()
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

        private void ModificarTarifa_Load(object sender, EventArgs e)
        {
            //ComboBox
            cbZona.Texts = tarifa.zona.ToString();
            cbAnio.Texts = tarifa.año.ToString();
            cbMes.Texts = tarifa.mes.ToString();

            //TextBox
            txtBasico.Texts = tarifa.basico.ToString();
            txtIntermedio.Texts = tarifa.intermedio.ToString();
            txtExcedente.Texts = tarifa.excedente.ToString();
            txtCuota.Texts = tarifa.cuota.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorBasico = Valid.flotante(errorProv, txtBasico);
                errorIntermedio = Valid.flotante(errorProv, txtIntermedio);
                errorExcedente = Valid.flotante(errorProv, txtExcedente);
                errorCuota = Valid.flotante(errorProv, txtCuota);

                if (errorBasico || errorIntermedio || errorExcedente || errorCuota)
                {
                    MessageBox.Show("Verificar los campos.", "Error");
                    return;
                }
                else
                {
                    tarifa.basico = float.Parse(txtBasico.Texts);
                    tarifa.intermedio = float.Parse(txtIntermedio.Texts);
                    tarifa.excedente = float.Parse(txtExcedente.Texts);
                    tarifa.cuota = float.Parse(txtCuota.Texts);

                     Tarifa.sp_modificar_tarifa(tarifa);

                    MessageBox.Show("La tarifa ha sido modificada ", "Tarifa creada");

                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Valids de textbox
        private void txtBasico_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumF(e);
        }

        private void txtIntermedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumF(e);
        }

        private void txtExcedente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumF(e);
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumF(e);
        }
    }
}
