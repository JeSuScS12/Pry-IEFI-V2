using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Clases
{
    internal static class clsCarrito
    {
        public static DataTable carrito { get; set; }


        public static DataTable CargarDataSet(DataGridView tabla)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn columna in tabla.Columns)
            {
                dataTable.Columns.Add(columna.HeaderText);
            }

            foreach (DataGridViewRow fila in tabla.Rows)
            {
                if (!fila.IsNewRow) // Evitar la fila nueva en blanco
                {
                    DataRow row = dataTable.NewRow();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        row[celda.ColumnIndex] = celda.Value ?? DBNull.Value; // Manejar celdas nulas
                    }
                    dataTable.Rows.Add(row);
                }
            }
            return dataTable;
        }
    }
}
