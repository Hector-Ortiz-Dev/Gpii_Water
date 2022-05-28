using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpi_Water.ClasesVentana
{
    class MetodosVentanas
    {
        public MetodosVentanas() { }

        public void AdjustForm(int borderSize, Form wind)
        {
            switch (wind.WindowState)
            {
                case FormWindowState.Maximized:
                    wind.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (wind.Padding.Top != borderSize)
                        wind.Padding = new Padding(borderSize);
                    break;
            }
        }

        public void CollapseMenu(Panel panel, PictureBox picBox, Button boton, PictureBox picUser, Label lblTipo, Label lblNombre)
        {
            if (panel.Width > 200) //Contraer
            {
                panel.Width = 100;
                picBox.Visible = false;
                picUser.Dock = DockStyle.Fill;
                picUser.SizeMode = PictureBoxSizeMode.CenterImage;
                lblNombre.Visible = false;
                lblTipo.Visible = false;
                boton.Dock = DockStyle.Top;
                foreach (Button menuButton in panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else //Expandir
            {
                panel.Width = 230;
                picBox.Visible = true;
                picUser.Dock = DockStyle.Left;
                picUser.SizeMode = PictureBoxSizeMode.AutoSize;
                lblNombre.Visible = true;
                lblTipo.Visible = true;
                boton.Dock = DockStyle.None;
                foreach (Button menuButton in panel.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(0, 0, 0, 0);
                }
            }
        }
    }
}
