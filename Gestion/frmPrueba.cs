using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }




        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Column6"].Index && e.RowIndex >= 0)
            {
                // Detener el pintado por defecto
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                // Dibujar la imagen en el botón
                Image img = Image.FromFile("../../Resources/Delete2.png");
                Point imgLocation = new Point(
                    e.CellBounds.Left + (e.CellBounds.Width - img.Width) / 3,
                    e.CellBounds.Top + (e.CellBounds.Height - img.Height) / 5
                );
                e.Graphics.DrawImage(img, imgLocation);

                // Dibujar el borde del botón
                e.Paint(e.CellBounds, DataGridViewPaintParts.Border);
            }
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la columna del clic es la de botones
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Aquí realizas la acción que quieres cuando se hace clic en el botón
                MessageBox.Show($"Borrando Producto {e.RowIndex}");

                // Ejemplo: Eliminar la fila correspondiente
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
