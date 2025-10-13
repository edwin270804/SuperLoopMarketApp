namespace Proyecto_Final_2
{
    partial class Frmpago
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lbldinero = new System.Windows.Forms.Label();
            this.txtRecibido = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.btncobrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotalAPagar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblpagotarjeta = new System.Windows.Forms.Label();
            this.txtcard = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Finalizar Venta";
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEfectivo.Location = new System.Drawing.Point(41, 119);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(119, 45);
            this.chkEfectivo.TabIndex = 1;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            this.chkEfectivo.CheckedChanged += new System.EventHandler(this.chkEfectivo_CheckedChanged_1);
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTarjeta.Location = new System.Drawing.Point(217, 119);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(97, 45);
            this.chkTarjeta.TabIndex = 2;
            this.chkTarjeta.Text = "Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(128, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pago";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(14, 180);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(171, 28);
            this.lblTotalPagar.TabIndex = 4;
            this.lblTotalPagar.Text = "Cantidad a pagar:";
            // 
            // lbldinero
            // 
            this.lbldinero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbldinero.AutoSize = true;
            this.lbldinero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldinero.Location = new System.Drawing.Point(14, 282);
            this.lbldinero.Name = "lbldinero";
            this.lbldinero.Size = new System.Drawing.Size(161, 28);
            this.lbldinero.TabIndex = 9;
            this.lbldinero.Text = "Dinero Recibido:";
            // 
            // txtRecibido
            // 
            this.txtRecibido.BorderRadius = 15;
            this.txtRecibido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecibido.DefaultText = "";
            this.txtRecibido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecibido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecibido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecibido.DisabledState.Parent = this.txtRecibido;
            this.txtRecibido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecibido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecibido.FocusedState.Parent = this.txtRecibido;
            this.txtRecibido.ForeColor = System.Drawing.Color.Black;
            this.txtRecibido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecibido.HoverState.Parent = this.txtRecibido;
            this.txtRecibido.Location = new System.Drawing.Point(19, 314);
            this.txtRecibido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.PasswordChar = '\0';
            this.txtRecibido.PlaceholderText = "Ingrese Valor...";
            this.txtRecibido.SelectedText = "";
            this.txtRecibido.ShadowDecoration.Parent = this.txtRecibido;
            this.txtRecibido.Size = new System.Drawing.Size(267, 57);
            this.txtRecibido.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BorderRadius = 11;
            this.btnCerrar.CheckedState.Parent = this.btnCerrar;
            this.btnCerrar.CustomImages.Parent = this.btnCerrar;
            this.btnCerrar.FillColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.Image = global::Proyecto_Final_2.Properties.Resources.cerrar_sesion__1_;
            this.btnCerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCerrar.Location = new System.Drawing.Point(207, 523);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(126, 45);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btncobrar
            // 
            this.btncobrar.BorderRadius = 11;
            this.btncobrar.CheckedState.Parent = this.btncobrar;
            this.btncobrar.CustomImages.Parent = this.btncobrar;
            this.btncobrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncobrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncobrar.ForeColor = System.Drawing.Color.White;
            this.btncobrar.HoverState.Parent = this.btncobrar;
            this.btncobrar.Image = global::Proyecto_Final_2.Properties.Resources.saco_de_dinero;
            this.btncobrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncobrar.Location = new System.Drawing.Point(19, 523);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.ShadowDecoration.Parent = this.btncobrar;
            this.btncobrar.Size = new System.Drawing.Size(141, 45);
            this.btncobrar.TabIndex = 12;
            this.btncobrar.Text = "Cobrar";
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click_1);
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.BorderRadius = 15;
            this.txtTotalAPagar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAPagar.DefaultText = "";
            this.txtTotalAPagar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAPagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAPagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAPagar.DisabledState.Parent = this.txtTotalAPagar;
            this.txtTotalAPagar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAPagar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAPagar.FocusedState.Parent = this.txtTotalAPagar;
            this.txtTotalAPagar.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAPagar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAPagar.HoverState.Parent = this.txtTotalAPagar;
            this.txtTotalAPagar.Location = new System.Drawing.Point(19, 212);
            this.txtTotalAPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.PasswordChar = '\0';
            this.txtTotalAPagar.PlaceholderText = "Ingrese Valor...";
            this.txtTotalAPagar.SelectedText = "";
            this.txtTotalAPagar.ShadowDecoration.Parent = this.txtTotalAPagar;
            this.txtTotalAPagar.Size = new System.Drawing.Size(267, 57);
            this.txtTotalAPagar.TabIndex = 14;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblCambio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.Transparent;
            this.lblCambio.Location = new System.Drawing.Point(12, 74);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(86, 28);
            this.lblCambio.TabIndex = 11;
            this.lblCambio.Text = "Cambio:";
            // 
            // lblpagotarjeta
            // 
            this.lblpagotarjeta.AutoSize = true;
            this.lblpagotarjeta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagotarjeta.Location = new System.Drawing.Point(14, 388);
            this.lblpagotarjeta.Name = "lblpagotarjeta";
            this.lblpagotarjeta.Size = new System.Drawing.Size(161, 28);
            this.lblpagotarjeta.TabIndex = 15;
            this.lblpagotarjeta.Text = "Pago con Tarjeta";
            this.lblpagotarjeta.Visible = false;
            // 
            // txtcard
            // 
            this.txtcard.BorderRadius = 15;
            this.txtcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcard.DefaultText = "";
            this.txtcard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcard.DisabledState.Parent = this.txtcard;
            this.txtcard.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcard.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcard.FocusedState.Parent = this.txtcard;
            this.txtcard.ForeColor = System.Drawing.Color.Black;
            this.txtcard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcard.HoverState.Parent = this.txtcard;
            this.txtcard.Location = new System.Drawing.Point(19, 431);
            this.txtcard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcard.Name = "txtcard";
            this.txtcard.PasswordChar = '\0';
            this.txtcard.PlaceholderText = "Ingrese monto con Tarjeta...";
            this.txtcard.SelectedText = "";
            this.txtcard.ShadowDecoration.Parent = this.txtcard;
            this.txtcard.Size = new System.Drawing.Size(267, 57);
            this.txtcard.TabIndex = 16;
            this.txtcard.Visible = false;
            // 
            // Frmpago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 580);
            this.Controls.Add(this.txtcard);
            this.Controls.Add(this.lblpagotarjeta);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.txtRecibido);
            this.Controls.Add(this.lbldinero);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkTarjeta);
            this.Controls.Add(this.chkEfectivo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmpago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmpago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldinero;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btncobrar;
        private Guna.UI2.WinForms.Guna2TextBox txtRecibido;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAPagar;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblpagotarjeta;
        private Guna.UI2.WinForms.Guna2TextBox txtcard;
    }
}