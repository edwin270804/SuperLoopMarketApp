using Guna.UI2.WinForms;
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
    public partial class Frmingresar : Form
    {
        public Frmingresar()
        {
            InitializeComponent();
        }

        private void Frmingresar_Load(object sender, EventArgs e)
        {
          
            EstiloBoton(btninicio, Color.MediumSeaGreen);
            this.DoubleBuffered = true;




        }

        private void EstiloBoton(Guna.UI2.WinForms.Guna2Button btn, Color colorBase)
        {
            btninicio.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            btninicio.ForeColor = Color.White;
            btninicio.FillColor = colorBase;
            btninicio.BorderRadius = 10;

            btninicio.HoverState.FillColor = ControlPaint.Dark(colorBase, 0.2f);
            btninicio.PressedColor = ControlPaint.Dark(colorBase, 0.4f);

            btninicio.ShadowDecoration.Enabled = true;
            btninicio.ShadowDecoration.Depth = 8;
            btninicio.ShadowDecoration.Color = Color.Gray;

            btn.Image = Properties.Resources.icon_user_24; 
            btn.ImageAlign = HorizontalAlignment.Left;
            btn.ImageSize = new Size(24, 24); 
            btn.TextAlign = HorizontalAlignment.Center;
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Frmlogincs logincs = new Frmlogincs();
            logincs.Show();
            this.Hide();
            
            
            
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click_2(object sender, EventArgs e)
        {
      
        }

        private void Frmingresar_Shown(object sender, EventArgs e)
        {
           
        }

        private void Frmingresar_Activated(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 768)
            {
                timer2.Stop();

                
                Frmlogincs logincs = new Frmlogincs();
                logincs.Show();
                this.Hide();
                
            }


        }
    }
}
