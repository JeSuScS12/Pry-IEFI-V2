using Gestion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gestion.Foms_Modulo_Inventario
{
    public partial class frmInventarioSolicitudStock : Form
    {
        public frmInventarioSolicitudStock()
        {
            InitializeComponent();
            Movimientodgv();

            //btnAgregar.Enabled = false;

            //btnAgregar.BackColor = Color.Gray;
            //txtnombre.TextChanged += TextBox_TextChanged;
            //txtDescripcion.TextChanged += TextBox_TextChanged;

            //txtStock.TextChanged += TextBox_TextChanged;
        }

        #region Controles de TextBoxs
        private void EstadoDeTextos()
        {
          
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            EstadoDeTextos();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void gpbAgregar_Enter(object sender, EventArgs e)
        {

        }
        clsInventario inventario = new clsInventario();

        private void frmInventarioSolicitudStock_Load(object sender, EventArgs e)
        {
            inventario.ListarProductos(dgvProductos);
            Dictionary<string, int> nivelesDeStock = inventario.ObtenerNivelesDeStock();

            // Configurar el gráfico
            chart1.Series.Clear();
            Series series = new Series("Niveles de Stock");
            series.ChartType = SeriesChartType.Bar;
            foreach (var item in nivelesDeStock)
            {
                int stock = item.Value;

                int pointIndex = series.Points.AddXY(item.Key, stock);
                if (stock < 3)
                {

                    // Cambiar el color de la barra a rojo
                    series.Points[pointIndex].Color = Color.Red;

                    // Mostrar un mensaje de alerta
                    MessageBox.Show($"Alerta: El producto {item.Key} tiene un stock bajo ({stock} unidades). Considera reponerlo.", "Alerta de Reposición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            chart1.Series.Add(series);

            // Configurar el eje X y Y
            chart1.ChartAreas[0].AxisX.Title = "Producto";
            chart1.ChartAreas[0].AxisY.Title = "Nivel de Stock";
            //AGREGAR LINEA HORIZONTAL PARA QUE MARQUE CUANDO HAYA MENOS DE 3 UNIDADES
            StripLine stripLine = new StripLine();
            stripLine.IntervalOffset = 3;  // Nivel de alerta
            stripLine.BorderColor = Color.Red;
            stripLine.BorderWidth = 2;
            stripLine.BorderDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisY.StripLines.Add(stripLine);

        }

        private void panelInventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Guardar reporte de inventario";
                saveFileDialog.FileName = "Reporte_Inventario.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    clsInventario inventario = new clsInventario();
                    inventario.ExportarCSV(saveFileDialog.FileName);
                }
            }
        }
        
        //Maneja el tamaño de las columnas y filas. Agrega barras de scroll lateral y vertical para mejorar la vista de los campos de productos
        private void Movimientodgv()
        {
            dgvProductos.ScrollBars = ScrollBars.Both;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                column.Width = 150;
            }
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Height = 30;
            }
        }
    }
}
