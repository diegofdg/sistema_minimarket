using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Minimarket.Presentacion
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
            //Application.Run(new Frm_Categorias());
            //Application.Run(new Frm_Marcas());
            //Application.Run(new Frm_Unidades_Medidas());
            //Application.Run(new Frm_Almacenes());
            //Application.Run(new Frm_Productos());
            //Application.Run(new Frm_Rubros());
            //Application.Run(new Frm_Departamentos());
            //Application.Run(new Frm_Provincias());
            Application.Run(new Frm_Distritos());
        }
    }
}
