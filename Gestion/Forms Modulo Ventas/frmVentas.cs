using Gestion.Clases;
using Gestion.Forms_Modulo_Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms_Modulos 
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        //Instanciar clases
        clsConexionVentas conectar = new clsConexionVentas();

        private void frmVentas_Load(object sender, EventArgs e)
        {
            //CREAR FUNCION QUE ME PERMITA SABER SI HAY UNA ORDEN DE COMPRA PENDIENTE ❌

            //AQUI



            //CARGA EL COMBO Y MUESTRA TODOS LOS PRODUCTOS AL CARGAR EL MODULO DE VENTAS
            
            conectar.CargarCMB(cmbCategoria);
            DataTable dt = conectar.EnviarModulos();
            Modulos(dt, panelContenedor);
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            panelContenedor.Size = new Size(1000, 400);
            panelCarrito.Size = new Size(1000, 240);
            lblCarrito.Visible = true;
            btnCancelarOrden.Visible = true;

            btnNuevaCompra.Enabled = false;
            
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar su Orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                panelContenedor.Size = new Size(1000, 610);
                panelCarrito.Size = new Size(1000, 50);
                lblCarrito.Visible = false;
                btnCancelarOrden.Visible = false;
                btnNuevaCompra.Enabled = true;

                dgvCarrito.Rows.Clear();
                ActualizarCarrito();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = conectar.EnviarModulos(txtBuscar.Text);
            Modulos(dt, panelContenedor);
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            DataTable dt = conectar.EnviarModulos(cmbCategoria.SelectedIndex+1);
            Modulos(dt, panelContenedor);
        }

        //Funcion de Modulos en FRM -- LISTO ✅
        private void Modulos(DataTable tabla, Panel panel)
        {
            panel.Controls.Clear();


            int xPos = 55;
            int yPos = 30;

            foreach (DataRow dr in tabla.Rows)
            {
                string codigo = dr["IdProducto"].ToString();
                string producto = dr["Nombre"].ToString();
                string precio = dr["Precio"].ToString();
                string descripcion = dr["Descripcion"].ToString();

                // Crear un nuevo panel
                Panel moduloProducto = new Panel();
                //moduloProducto.BorderStyle = BorderStyle.FixedSingle;
                moduloProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
                moduloProducto.Size = new System.Drawing.Size(150, 210);
                moduloProducto.Cursor = System.Windows.Forms.Cursors.Hand;
                moduloProducto.Location = new System.Drawing.Point(xPos, yPos);

                // Crear un nuevo label
                Label lblProducto = new Label();
                lblProducto.Location = new System.Drawing.Point(9, 5);
                lblProducto.ForeColor = System.Drawing.Color.White;
                lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                lblProducto.Text = producto;

                Label lblPrecio = new Label();
                lblPrecio.Location = new System.Drawing.Point(25, 145);
                lblPrecio.ForeColor = System.Drawing.Color.White;
                lblPrecio.Text = "Precio: " + precio + " ARS";

                //Crear PictureBox
                PictureBox imagen = new PictureBox();
                imagen.Image = global::Gestion.Properties.Resources.producto_Color;
                imagen.Location = new System.Drawing.Point(12, 30);
                imagen.Size = new System.Drawing.Size(127, 105);
                imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

                //Crear boton dentro del panel 
                Button agregar = new Button();
                agregar.Text = "Agregar";
                agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
                agregar.Size = new System.Drawing.Size(127, 34);
                agregar.Location = new System.Drawing.Point(12, 168);
                agregar.ForeColor = System.Drawing.Color.White;
                agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //Evento click del Boton
                agregar.Click += (s, e) =>
                {

                    if (panelCarrito.Height == 240)
                    {
                        clsProducto.codigo = Convert.ToInt32(codigo);
                        clsProducto.nombre = producto;
                        clsProducto.descripcion = descripcion;
                        clsProducto.precio = Convert.ToDecimal(precio);

                        frmVentas_Agregar frm = new frmVentas_Agregar();
                        frm.FormClosing += frm_close;
                        frm.ShowDialog();
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("¿Quiere abrir Nueva Orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            btnNuevaCompra_Click(this, EventArgs.Empty);
                        }
                    }
                };

                //Agregando controles  al Panel del producto
                moduloProducto.Controls.Add(lblProducto);
                moduloProducto.Controls.Add(lblPrecio);
                moduloProducto.Controls.Add(agregar);
                moduloProducto.Controls.Add(imagen);
                panel.Controls.Add(moduloProducto);

                // Actualizar las coordenadas para el próximo módulo
                xPos += 180;


                //Control si el proximo modulo exede el tamaño del panel conetenedor
                if (xPos + 150 > panel.Width)
                {
                    xPos = 55;
                    yPos += 230;
                }
            }
        }
        //FIN Modulos

        //Funcion frmAgregar-Close
        private void frm_close(object sender, FormClosingEventArgs e)
        {
            if(clsProducto.cant > 0)
            {
                Agregar(clsProducto.nombre, clsProducto.cant,clsProducto.precio);
            }
        }

        //Funcion Agregar a carrito
        private void Agregar(string producto, int cantidad, decimal precioUnitario)
        {
            decimal importe = cantidad * precioUnitario;
            dgvCarrito.Rows.Add(clsProducto.codigo, producto, cantidad, precioUnitario, importe);
            ActualizarCarrito();
        }

        private void ActualizarCarrito()
        {
            decimal totalCarrito = 0;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                totalCarrito += Convert.ToDecimal(row.Cells["column5"].Value);
            }
            //Mostrar en lblTotal
            lblTotal.Text = $"{totalCarrito:C2}";  // Formato de moneda C2
        }

        //Agregar icono al boton del DATAGRID
        private void dgvCarrito_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvCarrito.Columns["Column6"].Index && e.RowIndex >= 0)
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

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la columna del clic es la de botones
            if (dgvCarrito.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Aquí realizas la acción que quieres cuando se hace clic en el botón
                MessageBox.Show($"Eliminando del Carrito");
                dgvCarrito.Rows.RemoveAt(e.RowIndex);
                ActualizarCarrito();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            clsCarrito.carrito = clsCarrito.CargarDataSet(dgvCarrito);

            frmVentasPagar frm = new frmVentasPagar();
            frm.ShowDialog();
            
        }
    }
}
