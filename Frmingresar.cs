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
           // EstiloBoton(btninicio, Color.FromArgb(30, 144, 255)); // Azul
            EstiloBoton(btninicio, Color.MediumSeaGreen);       // Verde
           // EstiloBoton(btninicio, Color.DarkOrange);


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

            btn.Image = Properties.Resources.icon_user_24; // Reemplaza "LoginIcon" por el nombre de tu recurso de imagen
            btn.ImageAlign = HorizontalAlignment.Left;
            btn.ImageSize = new Size(24, 24); // Ajusta el tamaño del ícono según necesites
            btn.TextAlign = HorizontalAlignment.Center; // Mantener el texto centrado
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


    }
}
