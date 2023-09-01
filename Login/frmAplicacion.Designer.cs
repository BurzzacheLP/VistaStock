namespace Login
{
    partial class frmAplicacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAplicacion));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblConsulReportes = new System.Windows.Forms.Label();
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(24)))), ((int)(((byte)(85)))));
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.label2);
            this.sidePanel.Controls.Add(this.btnAdministrador);
            this.sidePanel.Controls.Add(this.btnLogOut);
            this.sidePanel.Controls.Add(this.lblInicio);
            this.sidePanel.Controls.Add(this.lblFecha);
            this.sidePanel.Controls.Add(this.lblVentas);
            this.sidePanel.Controls.Add(this.lblHora);
            this.sidePanel.Controls.Add(this.lblConsulReportes);
            this.sidePanel.Controls.Add(this.lblMantenimiento);
            this.sidePanel.Controls.Add(this.lblCompras);
            this.sidePanel.Controls.Add(this.lblAlmacen);
            this.sidePanel.Controls.Add(this.pictureBox2);
            this.sidePanel.Controls.Add(this.lblUserName);
            this.sidePanel.Location = new System.Drawing.Point(0, 23);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(149, 593);
            this.sidePanel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cargo / Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(8, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mantenimiento";
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrador.Image")));
            this.btnAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrador.Location = new System.Drawing.Point(45, 558);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(96, 28);
            this.btnAdministrador.TabIndex = 15;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(8, 558);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(31, 28);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblInicio.Image = ((System.Drawing.Image)(resources.GetObject("lblInicio.Image")));
            this.lblInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInicio.Location = new System.Drawing.Point(12, 84);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(61, 20);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "    &Inicio";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblFecha.Location = new System.Drawing.Point(5, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(91, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "DD / MM / YYYY";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblVentas.Image = ((System.Drawing.Image)(resources.GetObject("lblVentas.Image")));
            this.lblVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVentas.Location = new System.Drawing.Point(15, 210);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(74, 19);
            this.lblVentas.TabIndex = 10;
            this.lblVentas.Text = "      &Ventas";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(97, 55);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(49, 13);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "00:00:00";
            // 
            // lblConsulReportes
            // 
            this.lblConsulReportes.AutoSize = true;
            this.lblConsulReportes.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblConsulReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblConsulReportes.Image = ((System.Drawing.Image)(resources.GetObject("lblConsulReportes.Image")));
            this.lblConsulReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConsulReportes.Location = new System.Drawing.Point(15, 270);
            this.lblConsulReportes.Name = "lblConsulReportes";
            this.lblConsulReportes.Size = new System.Drawing.Size(87, 19);
            this.lblConsulReportes.TabIndex = 7;
            this.lblConsulReportes.Text = "      &Reportes";
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("lblMantenimiento.Image")));
            this.lblMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMantenimiento.Location = new System.Drawing.Point(15, 240);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(127, 19);
            this.lblMantenimiento.TabIndex = 6;
            this.lblMantenimiento.Text = "      &Mantenimiento";
            this.lblMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblCompras.Image = ((System.Drawing.Image)(resources.GetObject("lblCompras.Image")));
            this.lblCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompras.Location = new System.Drawing.Point(15, 180);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(88, 19);
            this.lblCompras.TabIndex = 5;
            this.lblCompras.Text = "      &Compras";
            this.lblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("lblAlmacen.Image")));
            this.lblAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlmacen.Location = new System.Drawing.Point(15, 150);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(85, 19);
            this.lblAlmacen.TabIndex = 4;
            this.lblAlmacen.Text = "      &Almacen";
            this.lblAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblUserName.Location = new System.Drawing.Point(40, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Usuario";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(72)))));
            this.TopPanel.Controls.Add(this.lblTitulo);
            this.TopPanel.Controls.Add(this.btnCerrar);
            this.TopPanel.Controls.Add(this.btnMinimizar);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1110, 24);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(539, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(32, 13);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Inicio";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1086, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1060, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelWorkspace.Location = new System.Drawing.Point(163, 33);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(935, 575);
            this.panelWorkspace.TabIndex = 14;
            // 
            // frmAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1110, 615);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panelWorkspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAplicacion";
            this.Text = "Aplicacon";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblConsulReportes;
        private System.Windows.Forms.Label lblMantenimiento;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Label label1;
    }
}

