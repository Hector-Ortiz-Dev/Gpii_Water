using CsvHelper;
using Gpi_Water.Conexion;
using Gpi_Water.Ventanas.SubVentanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpi_Water.Ventanas
{
    public partial class Tarifas : Form
    {
        int sel_idTarifa = -1;
        int sel_numRow = -1;

        public Tarifas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tarifas_Load(object sender, EventArgs e)
        {
            try
            {
                Tarifa.sp_get_tarifas(dgTarifas, cbAño.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbAño.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Tarifa.sp_get_tarifas(dgTarifas, cbAño.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarTarifa wnd = new AgregarTarifa();
            wnd.ShowDialog();

            Tarifas_Load(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sel_numRow != -1)
            {
                Tarifa tarifa = new Tarifa();

                tarifa.id = int.Parse(dgTarifas.Rows[sel_numRow].Cells["id"].Value.ToString());
                tarifa.zona = int.Parse(dgTarifas.Rows[sel_numRow].Cells["zona"].Value.ToString());
                tarifa.año = int.Parse(dgTarifas.Rows[sel_numRow].Cells["año"].Value.ToString());
                tarifa.mes = int.Parse(dgTarifas.Rows[sel_numRow].Cells["mes"].Value.ToString());
                tarifa.basico = float.Parse(dgTarifas.Rows[sel_numRow].Cells["basico"].Value.ToString());
                tarifa.intermedio = float.Parse(dgTarifas.Rows[sel_numRow].Cells["intermedio"].Value.ToString());
                tarifa.excedente = float.Parse(dgTarifas.Rows[sel_numRow].Cells["excedente"].Value.ToString());
                tarifa.cuota = float.Parse(dgTarifas.Rows[sel_numRow].Cells["cuota"].Value.ToString());

                ModificarTarifa wnd = new ModificarTarifa();
                wnd.tarifa = tarifa;
                wnd.ShowDialog();

                sel_numRow = -1;
                Tarifas_Load(sender, e);
            }
            else
                MessageBox.Show("Selecciona un empleado para modificarlo");
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            var reader = File.OpenText("tarifasMasivas.csv");
            var csvReader = new CsvReader(reader, CultureInfo.CurrentCulture);
            var lecturaCsv = csvReader.GetRecords<Tarifa>();
            foreach (var lectura in lecturaCsv)
            {
                if (Tarifa.sp_get_tarifa_masiva(lectura))
                {
                    MessageBox.Show("No se pudo cargar la tarifa porque ya existe :\n" +
                        "Zona: " + lectura.zona + "\n" +
                        "Año: " + lectura.año + "\n" +
                        "Mes: " + lectura.mes + "\n");
                }
                else
                    Tarifa.sp_masiva_tarifa(lectura);
            }
            MessageBox.Show("Carga masiva completada");
            Tarifas_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sel_idTarifa != -1)
            {
                Tarifa tarifa = new Tarifa(sel_idTarifa);
                
                try
                {
                    Tarifa.sp_eliminar_tarifa(tarifa);

                    MessageBox.Show("La tarifa ha sido eliminada.");
                    sel_idTarifa = -1;

                    Tarifas_Load(sender, e);
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    MessageBox.Show("La tarifa no se puede eliminar porque ya existe un recibo haciendo uso de eso");
                }
            }
        }

        private void dgTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;
            sel_idTarifa = int.Parse(dgTarifas.Rows[sel_numRow].Cells["id"].Value.ToString());
        }
    }
}
