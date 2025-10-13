using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_2
{
    public static class MostrarModal2
    {

        public static void Mostrarcapa(Form formularioprincipal, Form formularioModal, bool ocultarPrincipal = false)
        {
            Form capa = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black,
                Opacity = 0.3,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                Location = formularioprincipal.PointToScreen(Point.Empty),
                Size = formularioprincipal.ClientSize,
                TopMost = false,
                Owner = formularioprincipal
            };

            if (ocultarPrincipal)
            {
                formularioprincipal.Hide();
            }

            capa.Show();
            formularioModal.ShowInTaskbar = false;
            formularioModal.ShowDialog();
            capa.Close();

            if (ocultarPrincipal)
            {
                formularioprincipal.Close();
            }
        }
    }
}

