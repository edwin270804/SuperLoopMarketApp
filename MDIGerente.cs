using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Final_2
{
    public partial class MDIGerente : Form
    {

        public string nombreGerente;


        public MDIGerente(string nombre)
        {
            InitializeComponent();
            nombreGerente = nombre;





        }

      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void MDIGerente_Load(object sender, EventArgs e)
        {
            lblgerente.Text = nombreGerente;
            AbrirFormularioEnPanel4(new MDIdashboard());






        }

        private void gráficoDeVentasMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new MDIEstadisticas());
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            
            if (this.paneldinamico.Controls.Count > 0)
                this.paneldinamico.Controls.RemoveAt(0);

            formHijo.TopLevel = false;   
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;  

            this.paneldinamico.Controls.Add(formHijo);
            this.paneldinamico.Tag = formHijo;
            formHijo.Show();
        }

        private void productosMasVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel2(new MDIVentas_());
        }


        private void AbrirFormularioEnPanel2(Form formHijo)
        {

            if (this.paneldinamico.Controls.Count > 0)
                this.paneldinamico.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.paneldinamico.Controls.Add(formHijo);
            this.paneldinamico.Tag = formHijo;
            formHijo.Show();
        }

        private void toolsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
        "¿Deseas cerrar la sesión?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
        );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }




        private void icontrabajadores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel3(new MDItrabajadores());
        }

        private void AbrirFormularioEnPanel3(Form formHijo)
        {

            if (this.paneldinamico.Controls.Count > 0)
                this.paneldinamico.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.paneldinamico.Controls.Add(formHijo);
            this.paneldinamico.Tag = formHijo;
            formHijo.Show();
        }

        private void iconProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel5(new MDIProductos());
        }

        private void AbrirFormularioEnPanel5(Form formHijo)
        {

            if (this.paneldinamico.Controls.Count > 0)
                this.paneldinamico.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.paneldinamico.Controls.Add(formHijo);
            this.paneldinamico.Tag = formHijo;
            formHijo.Show();
        }



        private void paneldinamico_Paint(object sender, PaintEventArgs e)
        {


        }
        public void AbrirFormularioEnPanel4(Form formHijo)
        {
            if (this.paneldinamico.Controls.Count > 0)
            {
                
                Control ctrl = this.paneldinamico.Controls[0];

                
                if (ctrl is Form frm) frm.Close();

                
                this.paneldinamico.Controls.Clear();
            }

            // Configuración del formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.paneldinamico.Controls.Add(formHijo);
            this.paneldinamico.Tag = formHijo;
            formHijo.Show();

        }

        private void iconventas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel6(new MDIventas2());
        }

        private void AbrirFormularioEnPanel6(Form formHijo)
        {

            if (this.paneldinamico.Controls.Count > 0)
                this.paneldinamico.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.paneldinamico.Controls.Add(formHijo);
            this.paneldinamico.Tag = formHijo;
            formHijo.Show();
        }

        private void icondetalle_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel7(new MDIHistorial());
        }

        private void AbrirFormularioEnPanel7(Form formHijo)
        {

            if (this.paneldinamico.Controls.Count > 0)
                this.paneldinamico.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.paneldinamico.Controls.Add(formHijo);
            this.paneldinamico.Tag = formHijo;
            formHijo.Show();
        }
    }
}
