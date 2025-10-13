namespace Proyecto_Final_2
{
    partial class Frmlogincs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtcorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btningreso = new System.Windows.Forms.Button();
            this.iconcerrar = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcorreo
            // 
            this.txtcorreo.BorderColor = System.Drawing.Color.Black;
            this.txtcorreo.BorderRadius = 10;
            this.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo.DefaultText = "";
            this.txtcorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcorreo.DisabledState.Parent = this.txtcorreo;
            this.txtcorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcorreo.FocusedState.Parent = this.txtcorreo;
            this.txtcorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.Black;
            this.txtcorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcorreo.HoverState.Parent = this.txtcorreo;
            this.txtcorreo.Location = new System.Drawing.Point(249, 220);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PasswordChar = '\0';
            this.txtcorreo.PlaceholderText = "Correo";
            this.txtcorreo.SelectedText = "";
            this.txtcorreo.ShadowDecoration.Parent = this.txtcorreo;
            this.txtcorreo.Size = new System.Drawing.Size(278, 55);
            this.txtcorreo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio de Sesion";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderColor = System.Drawing.Color.Black;
            this.txtcodigo.BorderRadius = 10;
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.DefaultText = "";
            this.txtcodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigo.DisabledState.Parent = this.txtcodigo;
            this.txtcodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigo.FocusedState.Parent = this.txtcodigo;
            this.txtcodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigo.HoverState.Parent = this.txtcodigo;
            this.txtcodigo.Location = new System.Drawing.Point(249, 298);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.PlaceholderText = "Codigo";
            this.txtcodigo.SelectedText = "";
            this.txtcodigo.ShadowDecoration.Parent = this.txtcodigo;
            this.txtcodigo.Size = new System.Drawing.Size(278, 55);
            this.txtcodigo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_2.Properties.Resources.Imagen_de_WhatsApp_2025_09_05_a_las_11_42_51_c51e0fb3;
            this.pictureBox1.Location = new System.Drawing.Point(254, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btningreso
            // 
            this.btningreso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningreso.Location = new System.Drawing.Point(312, 372);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(165, 47);
            this.btningreso.TabIndex = 5;
            this.btningreso.Text = "Ingresar";
            this.btningreso.UseVisualStyleBackColor = true;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.BackColor = System.Drawing.Color.White;
            this.iconcerrar.FlatAppearance.BorderSize = 0;
            this.iconcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconcerrar.ForeColor = System.Drawing.Color.Black;
            this.iconcerrar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconcerrar.IconColor = System.Drawing.Color.Black;
            this.iconcerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcerrar.IconSize = 30;
            this.iconcerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconcerrar.Location = new System.Drawing.Point(12, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(150, 42);
            this.iconcerrar.TabIndex = 6;
            this.iconcerrar.Text = "Volver";
            this.iconcerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconcerrar.UseVisualStyleBackColor = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Frmlogincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.btningreso);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmlogincs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmlogincs";
            this.Load += new System.EventHandler(this.Frmlogincs_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtcorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtcodigo;
        private System.Windows.Forms.Button btningreso;
        private FontAwesome.Sharp.IconButton iconcerrar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}