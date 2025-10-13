using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_2;

namespace Proyecto_Final_2
{
    public partial class FrmRegistro : Form
    {
        public event Action TrabajadorAgregado;
        public FrmRegistro()
        {

            InitializeComponent();

            

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblcodigo;

            

            txtnombre.Text = "Nombre";
            txtnombre.ForeColor = Color.Black;

            cbxpuesto.Text = "Cargo";
            cbxpuesto.ForeColor = Color.DarkGray;

            // Conectar eventos
            txtcorreo.Enter += txtcorreo_Enter;
            txtcorreo.Leave += txtcorreo_Leave;
            txtcorreo.KeyDown += Control_KeyDown;

            txtnombre.Enter += txtnombre_Enter;
            txtnombre.Leave += txtnombre_Leave;
            txtnombre.KeyDown += Control_KeyDown;

            cbxpuesto.Enter += cbxpuesto_Enter;
            cbxpuesto.Leave += cbxpuesto_Leave;
            

            cbxpuesto.Items.Add("Cajero");
            cbxpuesto.Items.Add("Contador");
            cbxpuesto.Items.Add("Gerente");
            cbxpuesto.Items.Add("Limpieza");

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {


            string nombre = txtnombre.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string cargo = cbxpuesto.SelectedItem?.ToString();

            // Validaciones simples
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Generar código único
            string codigoAcceso = GenerarCodigoUnico();

            // Guardar en BD
            GuardarTrabajador(nombre, correo, cargo, codigoAcceso);

            // Disparar el evento DESPUÉS de guardar
            TrabajadorAgregado?.Invoke();

            // Mostrar el código en pantalla
            lblcodigo.Text = $"Código del Trabajador: {codigoAcceso}";

            // Enviar correo
            EnviarCorreo(correo, nombre, codigoAcceso);

            // Limpiar campos
            txtnombre.Clear();
            txtcorreo.Clear();
            txtnombre.Focus();

            //  Mostrar el código en pantalla
            lblcodigo.Text = $"Código del Trabajador: {codigoAcceso}";

            EnviarCorreo(correo, nombre, codigoAcceso);
        }

        private string GenerarCodigoUnico()
        {
          
            return Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        }

        private void GuardarTrabajador(string nombre, string correo, string rol, string codigoAcceso)
        {
            try
            {
                
                parametrosconexion parametros = AdministrarConexion.cargar();
                if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
                {
                    MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string conexion = parametros.cadenaConexion;

                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "INSERT INTO Trabajadores (Nombre, Correo, Rol, CodigoAcceso) " +
                                   "VALUES (@Nombre, @Correo, @Rol, @CodigoAcceso)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Rol", rol);
                        cmd.Parameters.AddWithValue("@CodigoAcceso", codigoAcceso);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Trabajador registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar trabajador: " + ex.Message);
            }
        }

        private void EnviarCorreo(string destinatario, string nombre, string codigoAcceso)
        {
            try
            {
                string remitente = ConfigurationManager.AppSettings["CorreoRemitente"];
                string clave = ConfigurationManager.AppSettings["ClaveRemitente"];
                string servidor = ConfigurationManager.AppSettings["SmtpServidor"];
                string puertoStr = ConfigurationManager.AppSettings["SmtpPuerto"];

                

                if (string.IsNullOrWhiteSpace(remitente) || string.IsNullOrWhiteSpace(clave) ||
                    string.IsNullOrWhiteSpace(servidor) || string.IsNullOrWhiteSpace(puertoStr))
                {
                    MessageBox.Show("Configuración de correo incompleta en App.config.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(destinatario) || destinatario == "Correo Electronico")
                {
                    MessageBox.Show("Debe ingresar un correo válido.");
                    return;
                }

                int puerto = int.Parse(puertoStr);

                SmtpClient cliente = new SmtpClient(servidor, puerto);
                cliente.Credentials = new System.Net.NetworkCredential(remitente, clave);
                cliente.EnableSsl = true;

                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress(remitente, "Loop Market - RRHH");
                mensaje.To.Add(destinatario);
                mensaje.Subject = "🎉 Bienvenido a Loop Market 🎉";
                mensaje.IsBodyHtml = true;

                mensaje.Body = $@"
        <html>
        <body style='font-family: Arial, sans-serif; text-align:center;'>
            <img src='https://i.imgur.com/gT3sdsm.jpeg' style='max-width:150px; margin-bottom:20px;'/>
            <h2>Hola {nombre},</h2>
            <p>¡Bienvenido al equipo de <b>Loop Market</b>! 🌟</p>
            <div style='background:#2ecc71; color:white; padding:15px; border-radius:8px; font-size:18px;'>
                Tu código de acceso personal es: <br/><b style='font-size:22px;'>{codigoAcceso}</b>
            </div>
            <p>Guarda este código, será necesario para acceder a funciones internas del sistema.<br/>
            Si tienes dudas, contáctanos en <a href='mailto:soporte@loopmarket.com'>soporte@loopmarket.com</a></p>
        </body>
        </html>";

                cliente.Send(mensaje);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: " + ex.Message);
            }
        }



        private void btnSesionIniciada_Click(object sender, EventArgs e)
        {
         
        }

        

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "Correo Electronico")
            {
                txtcorreo.Text = "";
                txtcorreo.ForeColor = Color.Black;
            }

        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcorreo.Text))
            {
              
            }



        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Nombre")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Nombre")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
            }
        }


        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                txtnombre.Text = "Nombre";
                txtnombre.ForeColor = Color.Gray;
            }

        }

        private void cbxpuesto_Enter(object sender, EventArgs e)
        {
            if (cbxpuesto.Text == "Cargo")
            {
                cbxpuesto.Text = "";
                cbxpuesto.ForeColor = Color.Black;
            }
        }

        private void cbxpuesto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxpuesto.Text))
            {
                cbxpuesto.Text = "Cargo";
                cbxpuesto.ForeColor = Color.Gray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

       



        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Frmlogincs frmLogincs = new Frmlogincs();
            MostrarModal2.Mostrarcapa(this, frmLogincs, true);
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


