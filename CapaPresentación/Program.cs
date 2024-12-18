using GestionAgenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    internal static class Program
    {

        public static Gestion gestion;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]


        static void Main()
        {
            gestion = new Gestion(out string errores);



            if (errores == "" )
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain(gestion));
            }
            else
            {
                MessageBox.Show(errores);
            }

        }
    }
}
