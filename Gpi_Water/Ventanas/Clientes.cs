using Gpi_Water.Conexion;
using Gpi_Water.Ventanas.SubVentanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpi_Water.Ventanas
{
    public partial class Clientes : Form
    {
        int sel_idCliente = -1;
        int sel_numRow = -1;

        public Clientes()
        {
            InitializeComponent();
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            Cliente.sp_get_clientes(dgClientes, "");
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente wnd = new AgregarCliente();
            wnd.ShowDialog();

            Clientes_Load(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(sel_numRow != -1)
            {
                Cliente cliente = new Cliente();

                cliente.id = int.Parse(dgClientes.Rows[sel_numRow].Cells["id"].Value.ToString());
                cliente.usuario = dgClientes.Rows[sel_numRow].Cells["usuario"].Value.ToString();
                cliente.nombre = dgClientes.Rows[sel_numRow].Cells["nombre"].Value.ToString();
                cliente.apellido_p = dgClientes.Rows[sel_numRow].Cells["apellido_p"].Value.ToString();
                cliente.apellido_m = dgClientes.Rows[sel_numRow].Cells["apellido_m"].Value.ToString();
                cliente.f_nacimiento = Convert.ToDateTime(dgClientes.Rows[sel_numRow].Cells["f_nacimiento"].Value.ToString());
                cliente.genero = dgClientes.Rows[sel_numRow].Cells["genero"].Value.ToString();

                string temp = dgClientes.Rows[sel_numRow].Cells["per_moral"].Value.ToString();
                if (temp == "False")
                    cliente.per_moral = false;
                else if (temp == "True")
                    cliente.per_moral = true;
                else
                {
                    MessageBox.Show("Error en conversion de per_moral");
                    return;
                }

                cliente.email = dgClientes.Rows[sel_numRow].Cells["email"].Value.ToString();
                cliente.curp = dgClientes.Rows[sel_numRow].Cells["curp"].Value.ToString();

                if (cliente.per_moral == true)
                    cliente.institucion = dgClientes.Rows[sel_numRow].Cells["institucion"].Value.ToString();
                else
                    cliente.institucion = "";

                cliente.rfc = dgClientes.Rows[sel_numRow].Cells["rfc"].Value.ToString();

                ModificarCliente wnd = new ModificarCliente();
                wnd.cliente = cliente;
                wnd.ShowDialog();

                Clientes_Load(sender, e);
            }
            else
                MessageBox.Show("Selecciona un cliente para modificarlo");
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (sel_idCliente != -1)
            {
                Cliente cliente = new Cliente(sel_idCliente);

                try
                {
                    Cliente.sp_desbanear(cliente);

                    MessageBox.Show("El usuario ha sido desbaneado.");

                    Clientes_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sel_idCliente != -1)
            {
                Cliente cliente = new Cliente(sel_idCliente);

                try
                {
                    Cliente.sp_baja_cliente(cliente);

                    MessageBox.Show("El usuario ha sido dado de baja.");

                    Clientes_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            Cliente.sp_get_clientes(dgClientes, txtBuscar.Texts);
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;
            sel_idCliente = int.Parse(dgClientes.Rows[sel_numRow].Cells["id"].Value.ToString());
        }
    }
}
