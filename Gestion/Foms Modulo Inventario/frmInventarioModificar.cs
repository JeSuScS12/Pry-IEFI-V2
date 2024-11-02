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
    public partial class frmInventarioModificar : Form
    {
        public frmInventarioModificar()
        {
            InitializeComponent();
            Movimientodgv();
            btnModificar.Enabled = false;
            btnModificar.BackColor = Color.Gray;
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
            btnModificar.Enabled = estado;
            if (estado == false) { btnModificar.BackColor = Color.Gray; }
            else { btnModificar.BackColor = Color.FromArgb(47, 117, 255); }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            EstadoDeTextos();
        }

        #endregion
        clsInventario clsInventario = new clsInventario();
        clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
        clsProveedoresInv clsProveedoresInv = new clsProveedoresInv();
        private void gpbModificar_Enter(object sender, EventArgs e)
        {

        }

        private void frmInventarioModificar_Load(object sender, EventArgs e)
        {
            clsInventario.ListarProductos(dgvProductos);
            clsCategoriasInv.CargaCMB(cmbCategoria);
            clsProveedoresInv.CargaCMB(cmbProveedor);
        }
        private void LimpiarComandos()
        {
            txtIdProd.Clear();
            txtDescripcion.Clear();
            txtnombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtIdProd.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtIdProd.Text);
            string Nombre = txtnombre.Text;
            string Descrip = txtDescripcion.Text;
            decimal Precio = Convert.ToDecimal(txtPrecio.Text);
            Int32 Stock = Convert.ToInt32(txtStock.Text);
            Int32 Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            Int32 Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
            clsInventario.Nombre = Nombre;
            clsInventario.Descripcion = Descrip;   
            clsInventario.Stock = Stock;
            clsInventario.Precio = Precio;
            clsInventario.idCategoria = Categoria;
            clsInventario.idProveedor = Proveedor;
            clsInventario.idProducto = id;
            clsInventario.ModificarProducto(id);
            LimpiarComandos();
            MessageBox.Show("Producto modificado con éxito");
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                // Llena los TextBox con los valores de la fila seleccionada
                txtIdProd.Text = filaSeleccionada.Cells["Column1"].Value.ToString();
                txtnombre.Text = filaSeleccionada.Cells["Column2"].Value.ToString();
                txtDescripcion.Text = filaSeleccionada.Cells["Column3"].Value.ToString();
                txtPrecio.Text = filaSeleccionada.Cells["Column4"].Value.ToString();
                txtStock.Text = filaSeleccionada.Cells["Column5"].Value.ToString();
                cmbCategoria.SelectedIndex = cmbCategoria.FindStringExact(filaSeleccionada.Cells["Column6"].Value.ToString());
                cmbProveedor.SelectedIndex = cmbProveedor.FindStringExact(filaSeleccionada.Cells["Column7"].Value.ToString());
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
        private void lblSeleccion_Click(object sender, EventArgs e)
        {

        }
        
        //Hace que solo se pueda colocar numeros en ambos textboxs
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
