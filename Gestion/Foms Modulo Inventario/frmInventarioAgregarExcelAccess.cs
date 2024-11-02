using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Clases;
using OfficeOpenXml;


namespace Gestion.Foms_Modulo_Inventario
{
    public partial class frmInventarioAgregarExcelAccess : Form
    {
        public frmInventarioAgregarExcelAccess()
        {
            InitializeComponent();
            Movimientodgv();
            gpvConfirmarReiniciar.Visible = false;
        }
        clsInventario clsInventario = new clsInventario();
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarExcel_Click(object sender, EventArgs e)
        {
            gpvConfirmarReiniciar.Visible = true;
            dgvProductos.Rows.Clear();
            ofdExcel.Title = "Buscar";
            ofdExcel.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";

            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofdExcel.FileName;
                try
                {
                    string extension = Path.GetExtension(ruta);

                    if (extension.Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                    {
                        // Cargar el archivo Excel
                        using (var package = new ExcelPackage(new FileInfo(ruta)))
                        {
                            var workbook = package.Workbook;
                            var worksheet = workbook.Worksheets[0]; 

                            int colCount = worksheet.Dimension.End.Column;
                            int rowCount = worksheet.Dimension.End.Row;

                            // Asumir que los encabezados ya están en el DataGridView
                            for (int row = 2; row <= rowCount; row++)
                            {
                                var newRow = new object[colCount];
                                for (int col = 1; col <= colCount; col++)
                                {
                                    newRow[col - 1] = worksheet.Cells[row, col].Text;
                                }
                                dgvProductos.Rows.Add(newRow);
                            }
                        }
                    }
                    else if (extension.Equals(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        // Leer el archivo CSV
                        var lines = File.ReadAllLines(ruta);

                        // Asumir que los encabezados ya están en el DataGridView
                        for (int i = 1; i < lines.Length; i++)
                        {
                            var row = lines[i].Split(',');
                            dgvProductos.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tipo de archivo no erroneo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
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

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            gpvConfirmarReiniciar.Visible = false;
            dgvProductos.Rows.Clear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verifica que el DataGridView tenga filas
            if (dgvProductos.Rows.Count > 0)
            {
                // Iterar sobre cada fila del DataGridView
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    // Asegúrate de que la fila no sea una fila vacia
                    if (!fila.IsNewRow)
                    {
                        
                        clsInventario.Nombre = fila.Cells["Column2"].Value?.ToString();
                        clsInventario.Descripcion = fila.Cells["Column3"].Value?.ToString();
                        clsInventario.Precio = fila.Cells["Column4"].Value != null ? Convert.ToDecimal(fila.Cells["Column4"].Value) : 0;
                        clsInventario.Stock = fila.Cells["Column5"].Value != null ? Convert.ToInt32(fila.Cells["Column5"].Value) : 0;
                        clsInventario.idCategoria = fila.Cells["Column6"].Value != null ? Convert.ToInt32(fila.Cells["Column6"].Value) : 0;
                        clsInventario.idProveedor = fila.Cells["Column7"].Value != null ? Convert.ToInt32(fila.Cells["Column7"].Value) : 0;
                        clsInventario.FechaIngreso = fila.Cells["Column8"].Value != null ? Convert.ToDateTime(fila.Cells["Column8"].Value) : DateTime.MinValue;

                        clsInventario.AgregarProducto();
                    }
                }
                MessageBox.Show("Datos cargados correctamente", "Es posible que el IdProductos sea cambiado para evitar conflictos en la base de datos");
            }
            else
            {
                MessageBox.Show("No hay datos para leer.");
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductos.Columns["Column3"].Index)
            {
                // Ajusta automáticamente el ancho de la columna de Descripción
                dgvProductos.AutoResizeColumn(e.ColumnIndex, DataGridViewAutoSizeColumnMode.DisplayedCells);
            }
        }
    }
}
