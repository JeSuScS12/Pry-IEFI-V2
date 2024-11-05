using Gestion.Foms_Modulo_Inventario;
using Gestion.Forms_Clientes_Usuarios_Empleados_;
using Gestion.Forms_Modulos;
using Gestion.Forms_Otros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPrincipal());
            Application.Run(new frmInventario());
        }
    }
}
