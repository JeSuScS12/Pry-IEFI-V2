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

        clsConexionClientes ObjClientes = new clsConexionClientes();
        private bool dibujando = false;
        private Point puntoAnterior;
        private Bitmap firmaBitmap;
        private bool firmaDibujada = false;

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ObjClientes.CargarNombres(cmbNombres);
        }

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
            if (txtNombre.Text != "" && firmaDibujada)
            {
                try
                {
                    // Guardar la firma en formato PNG o JPG
                    //string filePath = "firma.png";
                    //firmaBitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                    //MessageBox.Show("Firma guardad como PNG");

                    string nombre = txtNombre.Text;
                    // Luego de guardar la imagen, se convierte a byte[] para guardarla en la base de datos
                    byte[] imageBytes = FirmaVectorByte(firmaBitmap);

                    ObjClientes.GuardarFirma(nombre, imageBytes);
                    MessageBox.Show("Se ha guardado la firma y el nombre.");
                    txtNombre.Text = "";

                    firmaBitmap = new Bitmap(picFirma.Width, picFirma.Height);
                    picFirma.Image = firmaBitmap;

                    firmaDibujada = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe colocar nombre y dibujar una firma.");
            }
        }
        public byte[] FirmaVectorByte(Image imageIn)
        {
            // Esta funcion convierte la imagen en un vector de bytes para poder guardarla en access
            // Despues para traer esa imagen se lee desde access y se convierte a imagen
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Luego de guardar la firma en la base de datos, se crea un nuevo Bitmap simulando limpiar el picturebox
            firmaBitmap = new Bitmap(picFirma.Width, picFirma.Height);
            picFirma.Image = firmaBitmap;

            txtNombre.Text = "";
            cmbNombres.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cmbNombres.Text != "")
            {
                string nombre = cmbNombres.Text;
                ObjClientes.MostrarFirma(nombre, picFirma);
            }
        }
    }
}
