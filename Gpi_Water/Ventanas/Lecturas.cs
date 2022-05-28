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
    public partial class Lecturas : Form
    {
        int sel_num_ref = -1;
        int sel_numRow = -1;

        public Lecturas()
        {
            InitializeComponent();
        }

        private void Lecturas_Load(object sender, EventArgs e)
        {
            cbAño.SelectedIndex = 0;
            txtBuscar.Texts = "";
            Cliente.sp_get_cliente_contrato_cb(cbClientes, txtBuscar.Texts);

            cbAñoR.SelectedIndex = 0;
            cbMesR.SelectedIndex = 0;
            cbTipoR.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string num_ref = cbClientes.Texts.Substring(0, 6);
            int num_ref_c = int.Parse(num_ref);

            Lectura.sp_get_consumos(dgConsumos, cbAño.Texts, num_ref_c.ToString());
        }
        
        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            Cliente.sp_get_cliente_contrato_cb(cbClientes, txtBuscar.Texts);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbClientes.Texts != "")
            {
                string num_ref = cbClientes.Texts.Substring(0, 6);
                int num_ref_c = int.Parse(num_ref);

                CapturarLectura wnd = new CapturarLectura();
                wnd.num_ref = num_ref_c;
                wnd.ShowDialog();
                Lecturas_Load(sender, e);
            }
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            var reader = File.OpenText("lecturasMasivas.csv");
            var csvReader = new CsvReader(reader, CultureInfo.CurrentCulture);
            var lecturaCsv = csvReader.GetRecords<Lectura>();
            foreach (var lectura in lecturaCsv)
            {
                if (Lectura.sp_get_consumos_valid(lectura))
                {
                    MessageBox.Show("No se pudo cargar esta lectura por que ya existe\n" +
                        "Mes:" + lectura.mes + "\n" +
                        "Año:" + lectura.año + "\n" +
                        "Num_ref:" + lectura.fk_num_ref);
                }
                else
                    Lectura.sp_agregar_consumo(lectura);
            }
            MessageBox.Show("Carga masiva completada");
            Lecturas_Load(sender, e);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Lectura> lecturas = Lectura.sp_get_consumo_recibo(int.Parse(cbAñoR.Texts), int.Parse(cbMesR.Texts), cbTipoR.Texts);

            if(lecturas != null)
            {
                foreach(Lectura lectura in lecturas)
                {
                    Recibo.calcular_recibo(lectura);
                }
            }
        }

        private void dgConsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;
            sel_num_ref = int.Parse(dgConsumos.Rows[sel_numRow].Cells["fk_num_ref"].Value.ToString());
        }
    }
}
