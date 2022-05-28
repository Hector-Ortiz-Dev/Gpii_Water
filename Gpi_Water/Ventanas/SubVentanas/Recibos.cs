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
    public partial class Recibos : Form
    {
        Valid v = new Valid();
        private int borderSize = 2;
        public Sesion sesion;

        int sel_idRecibo = -1;
        int sel_numRow = -1;

        bool errorPago = true;

        public Recibos()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //Tamano del brode
            this.BackColor = Color.FromArgb(98, 102, 244); //Color del borde
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recibos_Load(object sender, EventArgs e)
        {
            txtCantidad.Texts = "";
            Recibo.sp_get_recibos(dgRecibos, sesion.id);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (sel_idRecibo != -1) //Si no selecciona algo del dg
            {
                errorPago = Valid.flotante(errorProv, txtCantidad);
                if (errorPago) //Si esta mal escrito el precio
                {
                    MessageBox.Show("Verificar su pago");
                    return;
                }
                else
                {
                    Recibo recibo = new Recibo();

                    recibo.id = sel_idRecibo;
                    recibo.total_pago = float.Parse(dgRecibos.Rows[sel_numRow].Cells["total_pago"].Value.ToString());
                    recibo.por_pagar = float.Parse(dgRecibos.Rows[sel_numRow].Cells["por_pagar"].Value.ToString());
                    //Cantidad a pagar
                    recibo.pagado = float.Parse(txtCantidad.Texts);
                       
                    if(recibo.por_pagar == 0)
                    {
                        MessageBox.Show("El recibo ya esta pagado");
                        return;
                    }
                    else if(recibo.pagado > recibo.por_pagar)//La cantidad a pagar es mayor a lo que se debe
                    {
                        MessageBox.Show("La cantidad a pagar supera a lo que se debe");
                        return;
                    }

                    Recibo.sp_pagar_recibo(recibo); //Pagar
                    if (recibo.pagado == recibo.por_pagar)
                        MessageBox.Show("El recibo ha sido pagado.");
                    else
                        MessageBox.Show("Cantidad a pagar actualizada.");
                    Recibos_Load(sender, e);
                }
            }
            else
                MessageBox.Show("Selecciona un recibo a pagar");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumF(e);
        }

        private void dgRecibos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;
            sel_idRecibo = int.Parse(dgRecibos.Rows[sel_numRow].Cells["id"].Value.ToString());
        }
    }
}