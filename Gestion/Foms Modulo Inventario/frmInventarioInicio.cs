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
    public partial class frmInventarioInicio : Form
    {
        
        public frmInventarioInicio()
        {
            InitializeComponent();
        }
        clsInventario clsInventario = new clsInventario();
        private void frmInventarioInicio_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> nivelesDeStock = clsInventario.ObtenerNivelesDeStock();

            // Configurar el gráfico
            chart1.Series.Clear();
            Series series = new Series("Niveles de Stock");
            series.ChartType = SeriesChartType.Bar;
            foreach (var item in nivelesDeStock)
            {
                int stock = item.Value;

                int pointIndex = series.Points.AddXY(item.Key, stock);
                if (stock < 3  )
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
