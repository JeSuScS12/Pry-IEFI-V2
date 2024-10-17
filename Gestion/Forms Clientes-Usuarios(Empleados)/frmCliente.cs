using Gestion.Clases;
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

namespace Gestion.Forms_Clientes_Usuarios_Empleados_
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            firmaBitmap = new Bitmap(picFirma.Width, picFirma.Height); // Bitmap para guardar la firma
            picFirma.Image = firmaBitmap;
        }

        //NOSE
        clsConexionClientes ObjClientes = new clsConexionClientes();
        private bool dibujando = false;
        private Point puntoAnterior;
        private Bitmap firmaBitmap;
        private bool firmaDibujada = false;


        private void frmCliente_Load(object sender, EventArgs e)
        {
            ObjClientes.CargarEstados(cmbEstado);
            ObjClientes.CargarClientes(dgvClientes);
            grbCliente.Enabled = false;

            //Agregado de Eventos OPT
            optModificar.CheckedChanged += new EventHandler(optSeleccionado);
            optRegistrar.CheckedChanged += new EventHandler(optSeleccionado);

            //Tamaño de los campos del DGV
            DiseñoTabla(dgvClientes);
        }


        //Dimensiones del DGV Clientes
        public void DiseñoTabla(DataGridView tabla)
        {
            tabla.Columns[0].Width = 40;
            tabla.Columns[1].Width = 210;
            tabla.Columns[2].Width = 125;
            tabla.Columns[3].Width = 180;
            tabla.Columns[4].Width = 135;
            tabla.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }


        //Funcion Capturar Firma ---------------------------------------------------------------------------
        private void picFirma_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = true;
                puntoAnterior = e.Location; // Guardamos el punto inicial
            }
        }

        private void picFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                using (Graphics g = Graphics.FromImage(firmaBitmap)) // Esto es para dibujar en el bitmap
                {
                    Pen pen = new Pen(Color.Black, 2);
                    g.DrawLine(pen, puntoAnterior, e.Location); // Aca toma el puntoAnterior y el siguiente y dibuja una linea, va dibujando la firma
                }
                picFirma.Invalidate();
                puntoAnterior = e.Location; // Se actualiza el punto anterior
                firmaDibujada = true; // con este booleano sabemos si se firmó o no
            }
        }

        private void picFirma_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = false;
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            frmGrabarFirma frm = new frmGrabarFirma();
            frm.FormClosing += frm_close;
            frm.ShowDialog();
        }


        private void frm_close(object sender, FormClosingEventArgs e)
        {
            CargarPicFirma(picFirma);
        }

        public void CargarPicFirma(PictureBox firma)
        {
            if (clsFirma.img != null)
            {
                firma.Image = clsFirma.img;
                firma.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar la imagen 
            }
            else
            {
                MessageBox.Show("No se guardo una Firma.");
            }
        }

        //Fin F. Capturar Firma ---------------------------------------------------------------------------



        //Funcio de Btn x OPT selecionado
        private void optSeleccionado(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Cambia  dependiendo del opt seleccionado
                if (rb == optModificar)
                {
                    txtDNI.Enabled = false;
                    grbCliente.Enabled = true;

                    EliminarBoton(grbCliente, "btn");
                    CrearBtnModificar("Modificar");
                }
                else if (rb == optRegistrar)
                {
                    txtDNI.Enabled = true;
                    grbCliente.Enabled = true;

                    txtDNI.Text = "";
                    txtNombre.Text = "";
                    txtCorreo.Text = "";
                    txtTelefono.Text = "";
                    cmbEstado.Text = "";

                    EliminarBoton(grbCliente, "btn");
                    CrearBtnRegistrar("Registrar");
                }
            }
        }

        //Extra  Funciones de Botnes Personalizados

        //REgistrar Clientes
        private void CrearBtnRegistrar(string nombre)
        {
            Button btn = new Button();
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(125, 186);
            btn.Size = new System.Drawing.Size(218, 45);
            btn.Text = nombre;
            btn.Name = "btn";

            //Crear eventos al btn
            btn.Click += (s, e) =>
            {
                int estado = cmbEstado.SelectedIndex + 1;
                ObjClientes.GuardarDatos(txtNombre.Text, txtDNI.Text, txtDireccion.Text, txtCorreo.Text, txtTelefono.Text, estado, picFirma);
                ObjClientes.CargarClientes(dgvClientes);
            };
            grbCliente.Controls.Add(btn);
        }
        //Modificar CLientes
        private void CrearBtnModificar(string nombre)
        {
            Button btn = new Button();
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(125, 186);
            btn.Size = new System.Drawing.Size(218, 45);
            btn.Text = nombre;
            btn.Name = "btn";

            //Crear eventos al btn
            btn.Click += (s, e) =>
            {
                int estado = cmbEstado.SelectedIndex + 1;
                ObjClientes.ModificarDatos(txtNombre.Text, txtDNI.Text, txtDireccion.Text, txtCorreo.Text, txtTelefono.Text, estado, picFirma);
                ObjClientes.CargarClientes(dgvClientes);
            };
            grbCliente.Controls.Add(btn);
        }


        //Funcion para borrar el boton creado por los opt
        private void EliminarBoton(GroupBox caja, string nombre)
        {
            // Recorrer los controles del GroupBox
            foreach (Control control in caja.Controls)
            {
                if (control is Button && control.Name == nombre)
                {
                    caja.Controls.Remove(control);
                    break;
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            picFirma.Image = null;

            if (dgvClientes.CurrentRow != null) // Verifica si hay una fila seleccionada
            {
                // Obtener la fila seleccionada actualmente
                DataGridViewRow fila = dgvClientes.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                int id = Convert.ToInt32(fila.Cells["ID"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string dni = fila.Cells["DNI"].Value.ToString();
                string correo = fila.Cells["Correo"].Value.ToString();
                string telef = fila.Cells["telefono"].Value.ToString();
                string estado = fila.Cells["Estado"].Value.ToString();

                // Mostrar los valores en cajas de texto
                txtNombre.Text = nombre;
                txtDNI.Text = dni;
                txtCorreo.Text = correo;
                txtTelefono.Text = telef;
                cmbEstado.Text = estado;

                ObjClientes.MostrarFirma(id, picFirma);
            }
        }
    }
}
