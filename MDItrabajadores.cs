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
using static Proyecto_Final_2.Frmcaja;

namespace Proyecto_Final_2
{
    public partial class MDItrabajadores : Form
    {

        private int registrosPorPagina = 10;      
        private int paginaActual = 1;            
        private int totalPaginas = 0;             
        private DataTable dtTrabajadoresCompleto;


        public MDItrabajadores()
        {
            InitializeComponent();

            this.IsMdiContainer = false;


        }



        private void trabajadores()
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
                string query = @"SELECT Idtrabajor, Nombre, Correo, Rol FROM Trabajadores;";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                dtTrabajadoresCompleto = new DataTable();
                da.Fill(dtTrabajadoresCompleto);
            }

            // Inicializar paginado
            paginaActual = 1;
            totalPaginas = (int)Math.Ceiling((double)dtTrabajadoresCompleto.Rows.Count / registrosPorPagina);

            
            MostrarPagina();
            CrearBotonesPaginado();

            

            dgvtrabajadores.DefaultCellStyle.ForeColor = Color.Black;
                dgvtrabajadores.DefaultCellStyle.BackColor = Color.White;
                dgvtrabajadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvtrabajadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

              ;
        }

        

        private void MostrarPagina()
        {
            if (dtTrabajadoresCompleto.Rows.Count == 0)
            {
                dgvtrabajadores.DataSource = null;
                return;
            }

            int inicio = (paginaActual - 1) * registrosPorPagina;
            var rows = dtTrabajadoresCompleto.AsEnumerable().Skip(inicio).Take(registrosPorPagina);

            dgvtrabajadores.DataSource = rows.Any() ? rows.CopyToDataTable() : null;

            // Ocultar columna Id
            if (dgvtrabajadores.Columns.Contains("Idtrabajor"))
                dgvtrabajadores.Columns["Idtrabajor"].Visible = false;

            PersonalizarDataGridView(dgvtrabajadores);

            dgvtrabajadores.DataSource = rows.Any() ? rows.CopyToDataTable() : null;

            if (dgvtrabajadores.DataSource != null)
            {
                if (dgvtrabajadores.Columns.Contains("Idtrabajor"))
                    dgvtrabajadores.Columns["Idtrabajor"].Visible = false;

                if (dgvtrabajadores.Columns.Contains("Nombre"))
                    dgvtrabajadores.Columns["Nombre"].ReadOnly = false;

                if (dgvtrabajadores.Columns.Contains("Correo"))
                    dgvtrabajadores.Columns["Correo"].ReadOnly = false;

                if (dgvtrabajadores.Columns.Contains("Rol"))
                    dgvtrabajadores.Columns["Rol"].ReadOnly = false;
            }

        }

        private void CrearBotonesPaginado()
        {
            if (flpPaginacion == null)
            {
                flpPaginacion = new FlowLayoutPanel();
                flpPaginacion.Size = new Size(300, 40);
                flpPaginacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                flpPaginacion.Location = new Point(this.ClientSize.Width - flpPaginacion.Width - 20, this.ClientSize.Height - flpPaginacion.Height - 20);
                flpPaginacion.BackColor = Color.Transparent;
                this.Controls.Add(flpPaginacion);
            }

            flpPaginacion.Controls.Clear();

            // Botón Para regresar
            Button btnAnterior = new Button();
            btnAnterior.Text = "<";
            btnAnterior.Width = 40;
            btnAnterior.Height = 30;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.BackColor = Color.White;
            btnAnterior.ForeColor = Color.Black;
            btnAnterior.Enabled = paginaActual > 1;
            btnAnterior.Click += (s, e) =>
            {
                if (paginaActual > 1)
                {
                    paginaActual--;
                    MostrarPagina();
                    CrearBotonesPaginado();
                }
            };
            flpPaginacion.Controls.Add(btnAnterior);


            int maxBotones = 3;
            int inicio = Math.Max(1, paginaActual - 1);
            int fin = Math.Min(totalPaginas, inicio + maxBotones - 1);

            for (int i = inicio; i <= fin; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Width = 40;
                btn.Height = 30;
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.Black;
                btn.BackColor = (i == paginaActual) ? Color.LightBlue : Color.White;

                int pagina = i;
                btn.Click += (s, e) =>
                {
                    paginaActual = pagina;
                    MostrarPagina();
                    CrearBotonesPaginado();
                };

                flpPaginacion.Controls.Add(btn);
            }


            Button btnSiguiente = new Button();
            btnSiguiente.Text = ">";
            btnSiguiente.Width = 40;
            btnSiguiente.Height = 30;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.ForeColor = Color.Black;
            btnSiguiente.Enabled = paginaActual < totalPaginas;
            btnSiguiente.Click += (s, e) =>
            {
                if (paginaActual < totalPaginas)
                {
                    paginaActual++;
                    MostrarPagina();
                    CrearBotonesPaginado();
                }
            };
            flpPaginacion.Controls.Add(btnSiguiente);



        }

        private void MDItrabajadores_Load(object sender, EventArgs e)
        {
            trabajadores();

            EstiloBoton(iconregistrar, Color.MediumSeaGreen);

            dgvtrabajadores.CellEndEdit += dgvtrabajadores_CellEndEdit;

            dgvtrabajadores.KeyDown += dgvtrabajadores_KeyDown;
            dgvtrabajadores.CellDoubleClick += dgvtrabajadores_CellDoubleClick;

            PersonalizarDataGridView(dgvtrabajadores);



        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
       
        }

        private DataTable dtTrabajadores;

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbuscar.Text.Trim();

            if (dtTrabajadores != null)
            {
                DataView dv = dtTrabajadores.DefaultView;
                dv.RowFilter = $"Nombre LIKE '%{filtro}%' OR Correo LIKE '%{filtro}%' OR Rol LIKE '%{filtro}%'";
                dgvtrabajadores.DataSource = dv;
            }

        }

        private void iconcerrar_Click_1(object sender, EventArgs e)
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

        private void iconregistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void iconactualizar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void EstiloBoton(Guna.UI2.WinForms.Guna2Button btn, Color colorBase)
        {
            btn.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.FillColor = colorBase;
            btn.BorderRadius = 10;

            btn.HoverState.FillColor = ControlPaint.Dark(colorBase, 0.2f);
            btn.PressedColor = ControlPaint.Dark(colorBase, 0.4f);

            btn.ShadowDecoration.Enabled = true;
            btn.ShadowDecoration.Depth = 8;
            btn.ShadowDecoration.Color = Color.Gray;

            btn.Image = Properties.Resources.agregar_usuario;
            btn.ImageAlign = HorizontalAlignment.Left;
            btn.ImageSize = new Size(24, 24); 
            btn.TextAlign = HorizontalAlignment.Center; 
        }

        private void iconregistrar_Click_1(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.TrabajadorAgregado += () => { trabajadores(); };
            MostrarModal.MostrarConCapa(this,frmRegistro);
        }

        private void dgvtrabajadores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            parametrosconexion parametros = AdministrarConexion.cargar();
            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
                return;

            string conexion = parametros.cadenaConexion;

            int id = Convert.ToInt32(dgvtrabajadores.Rows[e.RowIndex].Cells["Idtrabajor"].Value);
            string nombre = dgvtrabajadores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            string correo = dgvtrabajadores.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            string rol = dgvtrabajadores.Rows[e.RowIndex].Cells["Rol"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "UPDATE Trabajadores SET Nombre=@nombre, Correo=@correo, Rol=@rol WHERE Idtrabajor=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@rol", rol);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Registro actualizado correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void dgvtrabajadores_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete && dgvtrabajadores.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Deseas eliminar el/los trabajador(es) seleccionado(s)?",
                                                      "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    parametrosconexion parametros = AdministrarConexion.cargar();
                    if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
                        return;

                    string conexion = parametros.cadenaConexion;

                    using (SqlConnection conn = new SqlConnection(conexion))
                    {
                        conn.Open();
                        foreach (DataGridViewRow row in dgvtrabajadores.SelectedRows)
                        {
                            int id = Convert.ToInt32(row.Cells["Idtrabajor"].Value);
                            string query = "DELETE FROM Trabajadores WHERE Idtrabajor=@id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    trabajadores();
                    dgvtrabajadores.ReadOnly = true;
                }
            }
        }
        private void dgvtrabajadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

          
            dgvtrabajadores.ReadOnly = false;
            dgvtrabajadores.Columns["Idtrabajor"].ReadOnly = true;

            
            

            
            dgvtrabajadores.Rows[e.RowIndex].Selected = true;
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
