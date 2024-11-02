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
    public partial class frmInventarioBusqueda : Form
    {
        public frmInventarioBusqueda()
        {
            InitializeComponent();
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            txtCodigo.Clear();
            cmbCategoria.SelectedIndex = -1;
            //cmbStock.SelectedIndex = -1;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            //cmbStock.SelectedIndex = -1;
            if (cmbCategoria.SelectedIndex >= 0)
            {

            }
            else
            {

            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int codigo))
            { }
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            //cmbStock.SelectedIndex = -1;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmInventarioBusqueda_Load(object sender, EventArgs e)
        {
            inventario.ListarProductos(dgvProductos);
            categorias.CargaCMB(cmbCategoria);
            //inventario.CargaCMBStock(cmbStock);

        }
        clsInventario inventario = new clsInventario();
        clsCategoriasInv categorias = new clsCategoriasInv(); 
        clsProveedoresInv proveedores = new clsProveedoresInv();
        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
           
        }
        public void BotonesOpcion()
        {
            mrcBuscarxNombre.Enabled = false;
            mrcBuscarCategoria.Enabled = false;
            mrcCodigo.Enabled = false;

            if (optNombre.Checked)
            {
                mrcBuscarxNombre.Enabled = true;
                cmbCategoria.Text = "";
                txtCodigo.Text = "";
                dgvProductos.Rows.Clear();
            }
            else if (optCategoria.Checked)
            {
                mrcBuscarCategoria.Enabled = true;
                txtNombre.Text = "";
                txtCodigo.Text = "";
                dgvProductos.Rows.Clear();
            }
            else if (optCodigo.Checked)
            {
                mrcCodigo.Enabled = true;
                txtNombre.Text = "";
                cmbCategoria.Text = "";
                dgvProductos.Rows.Clear();
            }

        }
        private void txtNombre_TextChanged_2(object sender, EventArgs e)
        {
           
        }

        private void panelInventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cmbCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {    
               
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int idProducto))
            {
                // Llamar al método de búsqueda si se puede convertir el texto a un número
                inventario.Buscar(idProducto, dgvProductos);
            }
            else
            {
                // Limpiar la grilla si no hay un número válido en el campo de texto
                dgvProductos.Rows.Clear();
            }

        }

        private void gpbBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el texto de búsqueda desde el campo de texto (ej. txtNombreBusqueda)
                string nombreBusqueda = txtNombre.Text.Trim();

                // Validar que el campo no esté vacío
                if (string.IsNullOrEmpty(nombreBusqueda))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear instancia de la clase que contiene el método de búsqueda
                clsInventario inventario = new clsInventario();

                // Llamar al método de búsqueda con el nombre ingresado
                List<clsInventario> productosEncontrados = inventario.BuscarProductosPorNombre(nombreBusqueda);

                // Limpiar el DataGridView antes de agregar nuevos resultados
                dgvProductos.Rows.Clear();

                // Verificar si se encontraron productos
                if (productosEncontrados.Count > 0)
                {
                    // Agregar los productos encontrados a la grilla
                    foreach (clsInventario producto in productosEncontrados)
                    {
                        dgvProductos.Rows.Add(producto.idProducto, producto.Nombre, producto.Descripcion,
                                              producto.Precio, producto.Stock, producto.idCategoria,
                                              producto.idProveedor, producto.FechaIngreso);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron productos con ese nombre.", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optNombre_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }

        private void optCategoria_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }

        private void optCodigo_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            if (cmbCategoria.SelectedItem != null)
            {
                // Limpia la grilla antes de realizar una nueva búsqueda
               

                // Obtiene el ID de la categoría seleccionada del ComboBox
                int idCategoriaSeleccionada = Convert.ToInt32(cmbCategoria.SelectedValue);

                // Crea una instancia de la clase de inventario para realizar la búsqueda
                
                inventario.BuscarCateg(dgvProductos, idCategoriaSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
    }
}
