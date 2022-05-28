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
    public partial class CapturarLectura : Form
    {
        Valid v = new Valid();
        private int borderSize = 2;
        public int num_ref;

        bool errorConsumo = true;
        bool errorAnio = true;
        bool errorMes = true;

        public CapturarLectura()
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

        private void AgregarConsumo_Load(object sender, EventArgs e)
        {
            lblnumRef.Text = num_ref.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorConsumo = Valid.nombre(errorProv, txtConsumo);
                errorAnio = Valid.ComboValid(errorProv, cbAnio);
                errorMes = Valid.ComboValid(errorProv, cbMes);

                if (errorConsumo || errorMes || errorAnio)
                {
                    MessageBox.Show("Verificar los campos.", "Error");
                    return;
                }
                else
                {
                    Lectura consumo = new Lectura(
                        int.Parse(txtConsumo.Texts),
                        int.Parse(cbMes.Texts),
                        int.Parse(cbAnio.Texts),
                        int.Parse(lblnumRef.Text));

                    if (Lectura.sp_get_consumos_valid(consumo))
                    {
                        MessageBox.Show("Ya existe una lectura con estos parametros y contrato.", "Error");
                        return;
                    }

                    Lectura.sp_agregar_consumo(consumo);

                    MessageBox.Show("Se ha capturado la lectura", "Lectura capturada");

                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Num(e);
        }
    }
}
