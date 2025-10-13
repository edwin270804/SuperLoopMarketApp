using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;

namespace Proyecto_Final_2
{
    public partial class MDIventas2 : Form
    {
        

        public MDIventas2()
        {
            InitializeComponent();
            this.IsMdiContainer = false;
        }

        private void CargarVentas()
        {
            parametrosconexion parametros = AdministrarConexion.cargar();

            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
            {
                MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conexion = parametros.cadenaConexion;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = @"SELECT Fecha, Subtotal, IVA, Recibido, Vuelto FROM Ventas";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                dtCargarVentas = new DataTable();
                da.Fill(dtCargarVentas);

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = dtCargarVentas;

                dgvVentas.DefaultCellStyle.ForeColor = Color.Black;
                dgvVentas.DefaultCellStyle.BackColor = Color.White;
                dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

            private DataTable dtCargarVentas;

        private void MDIventas2_Load(object sender, EventArgs e)
        {
            CargarVentas();
            PersonalizarDataGridView(dgvVentas);
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            // Buscar el formulario principal MDIGerente
            MDIGerente gerenteForm = Application.OpenForms.OfType<MDIGerente>().FirstOrDefault();

            if (gerenteForm != null)
            {
                // Mostrar el formulario principal si estaba minimizado u oculto
                gerenteForm.Show();
                gerenteForm.BringToFront();

                // Cargar el dashboard dentro del panel
                gerenteForm.AbrirFormularioEnPanel4(new MDIdashboard());
            }
            else
            {
                // Si no existe, crearlo y cargar el dashboard
                gerenteForm = new MDIGerente(null);
                gerenteForm.Show();
                gerenteForm.AbrirFormularioEnPanel4(new MDIdashboard());
            }

            // Cerrar el formulario actual
            this.Close();
        }

        private void PersonalizarDataGridView(DataGridView dgv)
        {
            // 🔹 Estilo general
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;

            // 🔹 Encabezados
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204); // Azul moderno
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // ✅ Centrado
            dgv.ColumnHeadersHeight = 38;

            // 🔹 Filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centra el texto

            // 🔹 Filas alternadas (efecto zebra)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);

            // 🔹 Bordes y selección
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowTemplate.Height = 32;

            // 🔹 Ajuste automático de columnas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }
    }

  
    
}
