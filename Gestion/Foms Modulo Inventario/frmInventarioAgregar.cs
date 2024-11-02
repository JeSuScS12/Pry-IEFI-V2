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

namespace Gestion.Foms_Modulo_Inventario
{
    public partial class frmInventarioAgregar : Form
    {
        public frmInventarioAgregar()
        {
            InitializeComponent();
            Movimientodgv();
            btnAgregar.Enabled = false;
            btnAgregar.BackColor = Color.Gray;
            //Contoles que verifican si las cajas de texto contienen caracteres
            txtnombre.TextChanged += TextBox_TextChanged;
            txtDescripcion.TextChanged += TextBox_TextChanged;
            txtPrecio.TextChanged += TextBox_TextChanged;
            txtStock.TextChanged += TextBox_TextChanged;
        }
        #region Controles de TextBoxs
        private void EstadoDeTextos()
        {
            bool estado = !string.IsNullOrWhiteSpace(txtnombre.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtStock.Text);
            btnAgregar.Enabled = estado;
            if (estado == false) { btnAgregar.BackColor = Color.Gray; }
            else { btnAgregar.BackColor = Color.FromArgb(47, 117, 255); }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            EstadoDeTextos();
        }
       
        #endregion
        clsInventario clsInventario = new clsInventario();
        clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
        clsProveedoresInv clsProveedoresInv = new clsProveedoresInv();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void panelAgregar_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmInventarioAgregar_Load(object sender, EventArgs e)
        {
            clsInventario.ListarProductos(dgvProductos);
            clsCategoriasInv.CargaCMB(cmbCategoria);
            clsProveedoresInv.CargaCMB(cmbProveedor);
        }
        private void LimpiarComandos() 
        {
            txtDescripcion.Clear();
            txtnombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
           
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            
            clsInventario.Nombre = txtnombre.Text;
            clsInventario.Descripcion = txtDescripcion.Text;
            clsInventario.Precio = Convert.ToDecimal(txtPrecio.Text);
            clsInventario.Stock = Convert.ToInt32(txtStock.Text);
            clsInventario.idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            clsInventario.idProveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
            clsInventario.FechaIngreso = Convert.ToDateTime(dtpFecha.Value);

           
            clsInventario.AgregarProducto();

            MessageBox.Show("Producto agregado con éxito");
            LimpiarComandos();

           
            clsInventario.ListarProductos(dgvProductos);
        }

        private void panelAgregar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        //Hace que solo se pueda colocar numeros en ambos textboxs
        private void txtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
