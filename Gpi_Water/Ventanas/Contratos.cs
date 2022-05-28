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
    public partial class Contratos : Form
    {
        int sel_numRef = -1;
        int sel_numRow = -1;
        bool loading = true;

        Cliente cliente = new Cliente();

        public Contratos()
        {
            InitializeComponent();
        }

        private void Contratos_Load(object sender, EventArgs e)
        {
            loading = true;
            Cliente.sp_get_clientes_cb(cbClientes, txtBuscar.Texts);
            loading = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgContratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;

            try
            {
                sel_numRef = int.Parse(dgContratos.Rows[sel_numRow].Cells["num_ref"].Value.ToString());
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (loading == false)
            {
                string id = cbClientes.Texts.Substring(0, 7);
                int id_cliente = int.Parse(id);

                Contrato.sp_get_contratos(dgContratos, id_cliente.ToString());
            }
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            Cliente.sp_get_clientes_cb(cbClientes, txtBuscar.Texts);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (loading == false)
            {
                if (cbClientes.Texts != "")
                {
                    string id = cbClientes.Texts.Substring(0, 7);
                    int id_cliente = int.Parse(id);

                    AgregarContrato wnd = new AgregarContrato();
                    wnd.id_cliente = id_cliente;
                    wnd.ShowDialog();
                    Contratos_Load(sender, e);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (loading == false)
            {
                if (sel_numRow != -1)
                {
                    Contrato contrato = new Contrato();

                    contrato.num_ref = int.Parse(dgContratos.Rows[sel_numRow].Cells["num_ref"].Value.ToString());
                    contrato.medidor = int.Parse(dgContratos.Rows[sel_numRow].Cells["medidor"].Value.ToString());
                    contrato.tipo = dgContratos.Rows[sel_numRow].Cells["tipo"].Value.ToString();
                    contrato.categoria = dgContratos.Rows[sel_numRow].Cells["categoria"].Value.ToString();
                    contrato.municipio = dgContratos.Rows[sel_numRow].Cells["municipio"].Value.ToString();
                    contrato.cod_postal = int.Parse(dgContratos.Rows[sel_numRow].Cells["cod_postal"].Value.ToString());
                    contrato.colonia = dgContratos.Rows[sel_numRow].Cells["colonia"].Value.ToString();
                    contrato.calle = dgContratos.Rows[sel_numRow].Cells["calle"].Value.ToString();
                    contrato.num_ext = int.Parse(dgContratos.Rows[sel_numRow].Cells["num_ext"].Value.ToString());

                    ModificarContrato wnd = new ModificarContrato();
                    wnd.contrato = contrato;
                    wnd.ShowDialog();

                    Contratos_Load(sender, e);
                }
                else
                    MessageBox.Show("Selecciona un contrato");
            }
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (loading == false)
            {
                if (sel_numRef != -1)
                {
                    Contrato contrato = new Contrato(sel_numRef);
                    Contrato.sp_reactiva_contrato(contrato);

                    Contratos_Load(sender, e);
                    MessageBox.Show("El servicio se ha reactivado");
                }
                else
                    MessageBox.Show("Selecciona un contrato");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (loading == false)
            {
                if (sel_numRef != -1)
                {
                    Contrato contrato = new Contrato(sel_numRef);
                    Contrato.sp_baja_contrato(contrato);

                    Contratos_Load(sender, e);
                    MessageBox.Show("El servicio se ha dado de baja");
                }
                else
                    MessageBox.Show("Selecciona un contrato");
            }
        }
    }
}
