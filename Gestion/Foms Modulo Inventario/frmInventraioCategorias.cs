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
            gpbIngresar.Visible = false;
            gpbModificar.Visible = false;
            cmbEstado.SelectedIndex = 0;
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
<<<<<<< HEAD
=======

        private void frmInventraioCategorias_Load(object sender, EventArgs e)
        {
            clsCategoriasInv.ListarTablaCategorias(dgvCategorias);
            //clsCategoriasInv.CargaCMBID(cmbID);
            
        }
        clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Int32 estado = 1;  // Puedes cambiar este valor según tus necesidades
            string categoria = txtCategoriaAgregar.Text;
            string descripcion = txtDescripcion.Text;

            // Verifica que los campos de categoría y descripción no estén vacíos.
            if (!string.IsNullOrWhiteSpace(categoria) && !string.IsNullOrWhiteSpace(descripcion))
            {
                clsCategoriasInv.AgregarCat(categoria, descripcion, estado, dgvCategorias);
                txtCategoriaAgregar.Clear();
                txtDescripcion.Clear();
            }
            else
            {
                // Muestra un mensaje de error si alguno de los campos está vacío.
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

                // Verifica el estado y establece el índice correspondiente
                if (filaSeleccionada.Cells["Column4"].Value.ToString() == "Activo")
                {
                    cmbEstado.SelectedIndex = 0; // Asumiendo que "Activo" es el primer elemento del ComboBox
                }
                else if (filaSeleccionada.Cells["Column4"].Value.ToString() == "Desactivado")
                {
                    cmbEstado.SelectedIndex = 1; // Asumiendo que "Desactivo" es el segundo elemento del ComboBox
                }
                else
                {
                    cmbEstado.SelectedIndex = -1; 
                }
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
                Int32 nuevoEstado = cmbEstado.SelectedIndex + 1; // Asegúrate de que este índice sea correcto

                // Verificar que los campos de texto no estén vacíos
                if (string.IsNullOrEmpty(nuevoNombreCategoria))
                {
                    MessageBox.Show("Ingrese un nombre para la categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(nuevaDescripcion))
                {
                    MessageBox.Show("Ingrese una descripción para la categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Instanciar la clase y llamar al método de modificación
                clsCategoriasInv.ModificarCategoria(idCategoria, nuevoNombreCategoria, nuevaDescripcion, nuevoEstado, dgvCategorias);

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

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCategorias.Columns["Column3"].Index)
            {
                // Ajusta automáticamente el ancho de la columna de Descripción
                dgvCategorias.AutoResizeColumn(e.ColumnIndex, DataGridViewAutoSizeColumnMode.DisplayedCells);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cmbSeleccion.SelectedIndex == 0)
            {
                gpbIngresar.Visible = true;
                gpbModificar.Visible = false;
            }
            else
            {
                gpbModificar.Visible = true;
                gpbIngresar.Visible = false;
            }
        }
>>>>>>> Cambios finales de inventario, se realizaron modificaciones visuales y de codigo para tener una funcion nueva en la aplicacion para agregar listas de productos que la empresa ya posea
    }
}
