using Gpi_Water.ClasesVentana;
using Gpi_Water.Conexion;
using Gpi_Water.Ventanas;
using Gpi_Water.Ventanas.SubVentanas;
using RJCodeAdvance.RJControls;
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
    public partial class Principal : Form
    {
        //Metodos Ventanas
        MetodosVentanas metodosVentanas = new MetodosVentanas();

        public Sesion sesion;

        //Campos
        private int borderSize = 2;
        
        //Constructor
        public Principal()
        {
            InitializeComponent();
            //metodosVentanas.CollapseMenu(panelMenu, pictureBox1, btnMenu,picUser, lblTipo, lblNombre);
            this.Padding = new Padding(borderSize); //Tamano del brode
            this.BackColor = Color.FromArgb(98, 102, 244); //Color del borde
        }

        #region Funciones del formulario
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Quitar bordes y mantener adaptacion
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelMain.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelMain.Controls.Add(formulario);
                panelMain.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        #endregion

        #region botones_basicos
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            metodosVentanas.CollapseMenu(panelMenu,pictureBox1, btnMenu, picUser, lblTipo, lblNombre);
        }
        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
        private void Main_Load(object sender, EventArgs e)
        {
            lblTipo.Text = sesion.tipo;
            lblNombre.Text = sesion.usuario;

            if (sesion.tipo == "ADMINISTRADOR")
            {
                btnRecibos.Visible = false;
            }
            else if (sesion.tipo == "EMPLEADO")
            {
                btnRecibos.Visible = false;
                btnEmpleados.Visible = false;
            }
            else if (sesion.tipo == "CLIENTE")
            {
                btnEmpleados.Visible = false;
                btnClientes.Visible = false;
                btnBaneos.Visible = false;
                btnContratos.Visible = false;
                btnConsumos.Visible = false;
                btnTarifas.Visible = false;
                btnZonas.Visible = false;
                //Dropmenu
                btnRepTarifas.Visible = false;
                btnRepConsumos.Visible = false;
                btnRepGeneral.Visible = false;
            }
            else
                MessageBox.Show("Error al identificar el tipo de usuario");
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(dmSubmenu, sender);
        }

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            Recibos wnd = new Recibos();
            wnd.sesion = sesion;
            wnd.ShowDialog();
        }
        
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Clientes>();
            btnClientes.BackColor = Color.FromArgb(56, 182, 255);
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Contratos>();
            btnContratos.BackColor = Color.FromArgb(56, 182, 255);
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Tarifas>();
            btnTarifas.BackColor = Color.FromArgb(56, 182, 255);
        }

        private void btnConsumos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Lecturas>();
            btnConsumos.BackColor = Color.FromArgb(56, 182, 255);
        }

        private void btnBaneos_Click(object sender, EventArgs e)
        {
            Baneos wnd = new Baneos();
            wnd.sesion = sesion;
            wnd.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Empleados>();
            btnEmpleados.BackColor = Color.FromArgb(56, 182, 255);
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Zonas>();
            btnZonas.BackColor = Color.FromArgb(56, 182, 255);
        }

        //DropdownMenu Buttons
        private void btnRepTarifas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RepTarifas>();
        }

        private void btnRepConsumos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RepConsumo>();
        }

        private void btnRepGeneral_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RepGeneral>();
        }

        private void btnConHistorico_Click(object sender, EventArgs e)
        {
            ConHistorico wnd = new ConHistorico();
            wnd.sesion = sesion;
            wnd.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login wnd = new Login();
            wnd.Show();
        }

        // Events methods
        private void Main_Resize(object sender, EventArgs e)
        {
            metodosVentanas.AdjustForm(borderSize, this);
        }

        //Color de los botones clickeados
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Reportes"] == null)
                btnReportes.BackColor = Color.FromArgb(106, 90, 205);

            if (Application.OpenForms["Recibos"] == null)
                btnRecibos.BackColor = Color.FromArgb(106, 90, 205);

            if (Application.OpenForms["Clientes"] == null)
                btnClientes.BackColor = Color.FromArgb(106, 90, 205);

            if (Application.OpenForms["Contratos"] == null)
                btnContratos.BackColor = Color.FromArgb(106, 90, 205);

            if (Application.OpenForms["Tarifas"] == null)
                btnTarifas.BackColor = Color.FromArgb(106, 90, 205);

            if (Application.OpenForms["Consumos"] == null)
                btnConsumos.BackColor = Color.FromArgb(106, 90, 205);

            if (Application.OpenForms["Baneos"] == null)
                btnBaneos.BackColor = Color.FromArgb(106, 90, 205);

            if (Application.OpenForms["Empleados"] == null)
                btnEmpleados.BackColor = Color.FromArgb(106, 90, 205);

            if (Application.OpenForms["Zonas"] == null)
                btnZonas.BackColor = Color.FromArgb(106, 90, 205);
        }

        //Eventos de DropMenu
        private void Open_DropdownMenu(RJDropdownMenu dropMenu, object sender)
        {
            Control control = (Control)sender;
            dropMenu.VisibleChanged += new EventHandler((sender2, ev)
                => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropMenu.Show(control, control.Width, 0);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropMenu.Visible)
                    ctrl.BackColor = Color.FromArgb(0, 74, 173);
                else ctrl.BackColor = Color.FromArgb(98, 102, 244);
            }
        }
    }
}