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
    public partial class AgregarTarifa : Form
    {
        Valid v = new Valid();
        private int borderSize = 2;

        bool errorZona = true;
        bool errorAnio = true;
        bool errorMes = true;
        bool errorBasico = true;
        bool errorIntermedio = true;
        bool errorExcedente = true;
        bool errorCuota = true;

        public AgregarTarifa()
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

        private void AgregarTarifa_Load(object sender, EventArgs e)
        {
            Zona_v2.sp_get_zonas_v2_c(cbZona);
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
                errorZona = Valid.ComboValid(errorProv, cbZona);
                errorAnio = Valid.ComboValid(errorProv, cbAnio);
                errorMes = Valid.ComboValid(errorProv, cbMes);
                errorBasico = Valid.flotante(errorProv, txtBasico);
                errorIntermedio = Valid.flotante(errorProv, txtIntermedio);
                errorExcedente = Valid.flotante(errorProv, txtExcedente);
                errorCuota = Valid.flotante(errorProv, txtCuota);

                if (errorZona || errorMes || errorAnio || errorBasico ||
                    errorIntermedio || errorExcedente || errorCuota)
                {
                    MessageBox.Show("Verificar los campos.", "Error");
                    return;
                }
                else
                {
                    if (Tarifa.sp_get_tarifas_valid(
                        cbZona.Texts,
                        int.Parse(cbMes.Texts),
                        int.Parse(cbAnio.Texts)
                        ))
                    {
                        MessageBox.Show("Ya existe una tarifa con estos parametros.", "Error");
                        return;
                    }

                    Tarifa.sp_agregar_tarifa(
                        cbZona.Texts,
                        int.Parse(cbAnio.Texts),
                        int.Parse(cbMes.Texts),
                        float.Parse(txtBasico.Texts),
                        float.Parse(txtIntermedio.Texts),
                        float.Parse(txtExcedente.Texts),
                        float.Parse(txtCuota.Texts)
                        );

                    MessageBox.Show("La tarifa ha sido creada ", "Tarifa creada");

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
