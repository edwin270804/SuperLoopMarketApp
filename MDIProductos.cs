using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final_2.Frmcaja;

namespace Proyecto_Final_2
{
    public partial class MDIProductos : Form
    {
        private int childFormNumber = 0;

        public MDIProductos()
        {
            InitializeComponent();
            this.IsMdiContainer = false;
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

            
            this.Close();
        }

        private void CargarProductos()
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
                string query = @"
                    SELECT CodigoBarras AS [Codigo de Barras],
                           NombreProducto AS [Nombre Del Producto],
                           Categoria,
                           Precio,
                           Stock,
                           FechaIngreso AS [Fecha de Ingreso]
                    FROM SupermercadoProductos";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                dtCargarproductos = new DataTable();
                da.Fill(dtCargarproductos);

                dgvproductos.DataSource = null;
                dgvproductos.DataSource = dtCargarproductos;

                // Estilos generales
                dgvproductos.DefaultCellStyle.ForeColor = Color.Black;
                dgvproductos.DefaultCellStyle.BackColor = Color.White;
                dgvproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

            private DataTable dtCargarproductos;

        private void MDIProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            PersonalizarDataGridView(dgvproductos);
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
