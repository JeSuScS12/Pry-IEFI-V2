using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Clases
{
    internal static class clsFirma
    {
        public static Image img { get; set; }


        // Método opcional para cargar la imagen desde un byte array
        public static void CargarImagenDesdeBytes(byte[] imagenBytes)
        {
            using (var ms = new System.IO.MemoryStream(imagenBytes))
            {
                img = Image.FromStream(ms);
            }
        }
    }
}
