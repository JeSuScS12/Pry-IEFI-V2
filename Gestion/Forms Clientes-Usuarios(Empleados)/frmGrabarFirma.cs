using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Gestion.Clases;

namespace Gestion.Forms_Clientes_Usuarios_Empleados_
{
    public partial class frmGrabarFirma : Form
    {
        public frmGrabarFirma()
        {
            InitializeComponent();

            firmaBitmap = new Bitmap(picFirma.Width, picFirma.Height); // Bitmap para guardar la firma
            picFirma.Image = firmaBitmap;
        }

        private bool dibujando = false;
        private Point puntoAnterior;
        private Bitmap firmaBitmap;
        private bool firmaDibujada = false;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Luego de guardar la firma en la base de datos, se crea un nuevo Bitmap simulando limpiar el picturebox
            firmaBitmap = new Bitmap(picFirma.Width, picFirma.Height);
            picFirma.Image = firmaBitmap;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Luego de guardar la imagen, se convierte a byte[] para guardarla en la base de datos
                byte[] imageBytes = FirmaVectorByte(firmaBitmap);
                clsFirma.CargarImagenDesdeBytes(imageBytes);

                MessageBox.Show("Se ha guardado la firma.");

                firmaBitmap = new Bitmap(picFirma.Width, picFirma.Height);
                picFirma.Image = firmaBitmap;
                firmaDibujada = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            this.Close();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
