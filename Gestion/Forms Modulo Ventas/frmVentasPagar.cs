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

namespace Gestion.Forms_Modulo_Ventas
{
    public partial class frmVentasPagar : Form
    {
        public frmVentasPagar()
        {
            InitializeComponent();
            CargarTabla(dgvCarrito, clsCarrito.carrito);
        }

        //Instanciar clases
        
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentasPagar_Load(object sender, EventArgs e)
        {
            //Dando formato a las columnas
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.Columns[0].Width = 59;
            dgvCarrito.Columns[1].Width = 291;
            dgvCarrito.Columns[2].Width = 63;
            dgvCarrito.Columns[3].Width = 88;
            dgvCarrito.Columns[4].Width = 74;

            dgvCarrito.Columns.RemoveAt(5);

            ActualizarCarrito();
        }
        public void CargarTabla(DataGridView dataGridView, DataTable dataTable)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Asignar el DataTable como fuente de datos del DataGridView
            dataGridView.DataSource = dataTable;
        }

        private void ActualizarCarrito()
        {
            decimal totalCarrito = 0;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                totalCarrito += Convert.ToDecimal(row.Cells[4].Value);
            }
            //Mostrar en lblTotal
            lblTotal.Text = $"{totalCarrito:C2}";  // Formato de moneda C2
        }

    }
}
