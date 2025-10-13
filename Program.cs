using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_2
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

            
            var conexion = AdministrarConexion.cargar();

           
            if (string.IsNullOrWhiteSpace(conexion.servidor) || string.IsNullOrWhiteSpace(conexion.baseDatos))
            {
                using (var frm = new Frmconexion())
                {
                    
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("No se configuró la conexión. La aplicación se cerrará.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; 
                    }
                }
            }

            
            Application.Run(new Frmingresar());
        }
    }
}

