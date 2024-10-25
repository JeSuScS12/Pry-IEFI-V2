using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Clases
{
    internal static class clsUserGlobal
    {
        public static int id {  get; set; }
        public static string nombre { get; set; }
        public static string user { get; set; }
        public static string contraseña { get; set; }
        public static  string estado { get; set; }
        public static string cargo { get; set; }

        //Buscar como cargar imagen del usuario
        public static Image foto { get; set; }

    }
}
