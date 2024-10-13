using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Clases
{
    internal  class clsCarrito
    {
        public  DataSet carrito { get; set; }


        public  void CargarDataSet(DataGridView tabla)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in tabla.Columns)
            {
                dataTable.Columns.Add(column.Name, column.ValueType);
            }

            // Agregar las filas del DataGridView al DataTable
            foreach (DataGridViewRow row in tabla.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

        }
    }
}
