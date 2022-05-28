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
    public partial class Empleados : Form
    {
        int sel_idEmpleado = -1;
        int sel_numRow = -1;

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Empleado.sp_get_empleados(dgEmpleados, "");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            Empleado.sp_get_empleados(dgEmpleados, txtBuscar.Texts);
        }

        private void dgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;
            sel_idEmpleado = int.Parse(dgEmpleados.Rows[sel_numRow].Cells["id"].Value.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado wnd = new AgregarEmpleado();
            wnd.ShowDialog();

            Empleados_Load(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sel_numRow != -1)
            {
                Empleado empleado = new Empleado();

                empleado.id = int.Parse(dgEmpleados.Rows[sel_numRow].Cells["id"].Value.ToString());
                empleado.usuario = dgEmpleados.Rows[sel_numRow].Cells["usuario"].Value.ToString();
                empleado.nombre = dgEmpleados.Rows[sel_numRow].Cells["nombre"].Value.ToString();
                empleado.apellido_p = dgEmpleados.Rows[sel_numRow].Cells["apellido_p"].Value.ToString();
                empleado.apellido_m = dgEmpleados.Rows[sel_numRow].Cells["apellido_m"].Value.ToString();
                empleado.f_nacimiento = Convert.ToDateTime(dgEmpleados.Rows[sel_numRow].Cells["f_nacimiento"].Value.ToString());
                empleado.genero = dgEmpleados.Rows[sel_numRow].Cells["genero"].Value.ToString();
                empleado.domicilio = dgEmpleados.Rows[sel_numRow].Cells["domicilio"].Value.ToString();

                ModificarEmpleado wnd = new ModificarEmpleado();
                wnd.empleado = empleado;
                wnd.ShowDialog();

                sel_numRow = -1;
                Empleados_Load(sender, e);
            }
            else
                MessageBox.Show("Selecciona un empleado para modificarlo");
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (sel_idEmpleado != -1)
            {
                Empleado empleado = new Empleado(sel_idEmpleado);

                try
                {
                    Empleado.sp_desbanear(empleado);

                    MessageBox.Show("El usuario ha sido desbaneado.");

                    Empleados_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sel_idEmpleado != -1)
            {
                Empleado empleado = new Empleado(sel_idEmpleado);

                try
                {
                    Empleado.sp_baja_empleado(empleado);

                    MessageBox.Show("El usuario ha sido dado de baja.");
                    sel_idEmpleado = -1;

                    Empleados_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //Descartar modificacion en DataGrid
        private void dgEmpleados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (loading == false)
            //{
            //    int row_index = e.RowIndex;

            //    if(Valid.celdasLlenas(dgEmpleados, row_index) == false)
            //    {
            //        MessageBox.Show("Verificar que ningun campo de la tabla quede en blanco.", "Error");
            //        Empleados_Load(sender, e);
            //        return;
            //    }
            //    else if (Valid.cellCurpRfc(dgEmpleados, row_index) == false)
            //    {
            //        MessageBox.Show("El curp solo acepta 18 caracteres y el rfc solo acepta 13.", "Error");
            //        Empleados_Load(sender, e);
            //        return;
            //    }

            //    Guid id = Guid.Parse(dgEmpleados.Rows[rowIndex].Cells["id"].Value.ToString());
            //    string nombre = dgEmpleados.Rows[rowIndex].Cells["nombre"].Value.ToString();
            //    string apellido_p = dgEmpleados.Rows[rowIndex].Cells["apellido_p"].Value.ToString();
            //    string apellido_m = dgEmpleados.Rows[rowIndex].Cells["apellido_m"].Value.ToString();
            //    string curp = dgEmpleados.Rows[rowIndex].Cells["curp"].Value.ToString();
            //    string rfc = dgEmpleados.Rows[rowIndex].Cells["rfc"].Value.ToString();

            //    Empleado emp = new Empleado();
            //    emp.id = id;
            //    emp.nombre = nombre;
            //    emp.apellido_p = apellido_p;
            //    emp.apellido_m = apellido_m;
            //    emp.curp = curp;
            //    emp.rfc = rfc;

            //    Empleado.gestion_empleados("MODIFICAR", emp);
            //    Empleados_Load(sender, e);
            //}
        }
    }
}
