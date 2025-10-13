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
    public partial class Frminicio : Form
    {
        public Frminicio()
        {
            InitializeComponent();
        }

        private void brnregistrar_Click(object sender, EventArgs e)
        {
           FrmRegistro newregistro = new FrmRegistro();
            newregistro.Show();
            this.Hide();

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Frmlogincs logincs = new Frmlogincs();
            logincs.Show();
            this.Hide();

        }
    } 

     
}


