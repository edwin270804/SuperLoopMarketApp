using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_2
{
    public partial class Frmlogincs : Form
    {
        public Frmlogincs()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frmingresar ingresar = new Frmingresar();
            ingresar.Show();
            this.Hide();

        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            string correo = txtcorreo.Text.Trim();
            string codigo = txtcodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Los campos no pueden estar Vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = ValidarUsuario(correo, codigo);
            string nombreUsuario = resultado.nombre;
            string rol = resultado.rol;

            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("Acceso Concedido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rol == "Cajero")
                {
                    Frmcaja caja = new Frmcaja(nombreUsuario);
                    caja.Show();
                    this.Hide();
                }
                else if (rol == "Gerente")
                {
                    MDIGerente gerente = new MDIGerente(nombreUsuario); 
                    gerente.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Haz ingresado mal los datos, por favor vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private (string nombre, string rol) ValidarUsuario(string correo, string codigo)
        {
            try
            {
                
                parametrosconexion parametros = AdministrarConexion.cargar();
                if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
                {
                    MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return (null, null);
                }

                string conexion = parametros.cadenaConexion;

                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "SELECT Idtrabajor, Nombre, Rol FROM Trabajadores WHERE Correo=@Correo AND CodigoAcceso=@Codigo";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Codigo", codigo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Variables.idTrabajador = reader["Idtrabajor"].ToString();
                                return (reader["Nombre"].ToString(), reader["Rol"].ToString());
                            }
                            else
                            {
                                return (null, null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }
        }

        private void Frmlogincs_Load(object sender, EventArgs e)
        {


          
        }


        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "Correo")
            {
                txtcorreo.Text = "";
                txtcorreo.ForeColor = Color.Black;
            }
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcorreo.Text))
            {
                txtcorreo.Text = "Correo";
                txtcorreo.ForeColor = Color.Gray;
            }
        }


        private void txtcodigo_Enter(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "Codigo")
            {
                txtcodigo.Text = "";
                txtcodigo.ForeColor = Color.Black;
            }
        }



        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodigo.Text))
            {
                txtcodigo.Text = "Codigo";
                txtcodigo.ForeColor = Color.Gray;
            }
        }


        private void txtcorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtcodigo.Focus();
            }
        }


        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btningreso.PerformClick();
            }
        }

        public static class Variables
        {
            public static string idTrabajador { get; set; }
           

        }

        private void Frmlogincs_Load_1(object sender, EventArgs e)
        {
            txtcorreo.KeyDown += txtcorreo_KeyDown;
            txtcodigo.KeyDown += txtcodigo_KeyDown;
            this.ActiveControl = label1;

            txtcorreo.Text = "Correo";
            txtcorreo.ForeColor = Color.Black;


            txtcodigo.Text = "Codigo";
            txtcodigo.ForeColor = Color.Black ;

            txtcorreo.Enter += txtcorreo_Enter;
            txtcorreo.Leave += txtcorreo_Leave;

            txtcodigo.Enter += txtcodigo_Enter;
            txtcodigo.Leave += txtcodigo_Leave;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Frmingresar ingresar = new Frmingresar();
            ingresar.Show();
            this.Hide();
        }
    }
}

