using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_2
{
    public partial class Frmconexion : Form
    {
        public Frmconexion()
        {
            InitializeComponent();
        }

        // Botones de Comando

        private void btncerrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnaceptar_Click_1(object sender, EventArgs e)
        {
            bool datosValidos = true;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox gunatextbox)
                {
                    if (string.IsNullOrWhiteSpace(gunatextbox.Text))
                    {
                        erroricon.SetError(gunatextbox, "Este Campo es Obligatorio");
                        datosValidos = false;
                    }
                }
            }

            if (!datosValidos)
            {
                MessageBox.Show("Información incompleta. Serán remarcados los datos que faltan",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }

            //Crear objeto de configuracion
            var parametros = new parametrosconexion
            {
                servidor = txtservidor.Text.Trim(),
                baseDatos = txtdb.Text.Trim()


            };

            if (!AdministrarConexion.ProbarConexion(parametros, out string error))
            {
                MessageBox.Show($"No se pudo establecer la conexión con la base de datos.\n\nDetalles: {error}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            try
            {
                AdministrarConexion.Guardar(parametros);
                MessageBox.Show("Datos de conexion registrados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }


}

