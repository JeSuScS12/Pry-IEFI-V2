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
    public partial class frmInventraioCategorias : Form
    {
        public frmInventraioCategorias()
        {
            InitializeComponent();
            Movimientodgv();
        }

        private void lblCategoria2_Click(object sender, EventArgs e)
        {

        }

        private void lblcategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void frmInventraioCategorias_Load(object sender, EventArgs e)
        {
            clsCategoriasInv.ListarTablaCategorias(dgvCategorias);
            //clsCategoriasInv.CargaCMBID(cmbID);
            
        }
        clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string categoria =  txtCategoriaAgregar.Text;
            //clsCategoriasInv
            // Verifica que el campo de la categoría no esté vacío.
            if (!string.IsNullOrWhiteSpace(txtCategoriaAgregar.Text))
            {
                clsCategoriasInv.AgregarCat(txtCategoriaAgregar.Text, txtDescripcion.Text, dgvCategorias);   
                txtCategoriaAgregar.Clear();
                txtDescripcion.Clear();
                
            }
            else
            {
                // Muestra un mensaje de error si el campo está vacío.
                MessageBox.Show("Por favor, ingrese un nombre para la categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //clsCategoriasInv.ListarTablaCategorias(dgvCategorias);

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvCategorias.Rows[e.RowIndex];

                // Llena los TextBox con los valores de la fila seleccionada
                txtID.Text = filaSeleccionada.Cells["Column1"].Value.ToString();
                txtModificar.Text = filaSeleccionada.Cells["Column2"].Value.ToString();
                txtModificarDescripcion.Text = filaSeleccionada.Cells["Column3"].Value.ToString();
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                
                // Obtener el ID de la categoría seleccionada en la grilla
                int idCategoria = Convert.ToInt32(txtID.Text);

                // Obtener los nuevos valores ingresados en los campos de texto
                string nuevoNombreCategoria = txtModificar.Text.Trim();
                string nuevaDescripcion = txtModificarDescripcion.Text.Trim();

                // Verificar que los campos de texto no estén vacíos
                if (string.IsNullOrEmpty(nuevoNombreCategoria))
                {
                    MessageBox.Show("Ingrese un nombre para la categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Instanciar la clase y llamar al método de modificación
                
                clsCategoriasInv.ModificarCategoria(idCategoria, nuevoNombreCategoria, nuevaDescripcion, dgvCategorias);

                // Limpiar los campos de texto después de la modificación
                txtID.Clear();
                txtModificar.Clear();
                txtModificarDescripcion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar modificar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                

                // Confirmación de eliminación
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No)
                {
                    return;
                }

                // Obtener el ID de la categoría seleccionada
                int idCategoria = Convert.ToInt32(txtID.Text);

                // Llamar al método de eliminación
                clsCategoriasInv clsCategorias = new clsCategoriasInv();
                clsCategorias.EliminarCategoria(idCategoria, dgvCategorias);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Maneja el tamaño de las columnas y filas. Agrega barras de scroll lateral y vertical para mejorar la vista de los campos de productos
        private void Movimientodgv()
        {
            dgvCategorias.ScrollBars = ScrollBars.Both;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (DataGridViewColumn column in dgvCategorias.Columns)
            {
                column.Width = 150;
            }
            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                row.Height = 30;
            }
        }
        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtModificar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
