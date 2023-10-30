namespace Login
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnAbrirLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblUserState = new System.Windows.Forms.Label();
            this.lblNombreState = new System.Windows.Forms.Label();
            this.lblDniState = new System.Windows.Forms.Label();
            this.lblMailState = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefonoState = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboTipoTel = new System.Windows.Forms.ComboBox();
            this.Partido = new System.Windows.Forms.GroupBox();
            this.cboPartido = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Partido.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(563, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(537, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(72)))));
            this.TopPanel.Controls.Add(this.btnAbrirLogin);
            this.TopPanel.Controls.Add(this.btnCerrar);
            this.TopPanel.Controls.Add(this.btnMinimizar);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(595, 22);
            this.TopPanel.TabIndex = 11;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // btnAbrirLogin
            // 
            this.btnAbrirLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.btnAbrirLogin.Location = new System.Drawing.Point(6, 4);
            this.btnAbrirLogin.Name = "btnAbrirLogin";
            this.btnAbrirLogin.Size = new System.Drawing.Size(71, 15);
            this.btnAbrirLogin.TabIndex = 8;
            this.btnAbrirLogin.Text = "Login";
            this.btnAbrirLogin.UseVisualStyleBackColor = true;
            this.btnAbrirLogin.Click += new System.EventHandler(this.btnAbrirLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(24)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 136);
            this.panel1.TabIndex = 121;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(247, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 120;
            this.label1.Text = "Register";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(22, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 57);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // txtUser
            // 
            this.txtUser.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUser.Location = new System.Drawing.Point(6, 23);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 22);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Usuario123";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(303, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 57);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Correo";
            // 
            // txtMail
            // 
            this.txtMail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMail.Location = new System.Drawing.Point(6, 23);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(163, 22);
            this.txtMail.TabIndex = 4;
            this.txtMail.Text = "correo@mail.com";
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(177)))), ((int)(((byte)(91)))));
            this.lblUserState.Location = new System.Drawing.Point(203, 171);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(93, 13);
            this.lblUserState.TabIndex = 112;
            this.lblUserState.Text = "Usuario disponible";
            this.lblUserState.Visible = false;
            // 
            // lblNombreState
            // 
            this.lblNombreState.AutoSize = true;
            this.lblNombreState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(177)))), ((int)(((byte)(91)))));
            this.lblNombreState.Location = new System.Drawing.Point(203, 247);
            this.lblNombreState.Name = "lblNombreState";
            this.lblNombreState.Size = new System.Drawing.Size(76, 13);
            this.lblNombreState.TabIndex = 111;
            this.lblNombreState.Text = "Nombre Valido";
            this.lblNombreState.Visible = false;
            // 
            // lblDniState
            // 
            this.lblDniState.AutoSize = true;
            this.lblDniState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(177)))), ((int)(((byte)(91)))));
            this.lblDniState.Location = new System.Drawing.Point(485, 247);
            this.lblDniState.Name = "lblDniState";
            this.lblDniState.Size = new System.Drawing.Size(58, 13);
            this.lblDniState.TabIndex = 115;
            this.lblDniState.Text = "DNI Valido";
            this.lblDniState.Visible = false;
            // 
            // lblMailState
            // 
            this.lblMailState.AutoSize = true;
            this.lblMailState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(177)))), ((int)(((byte)(91)))));
            this.lblMailState.Location = new System.Drawing.Point(485, 171);
            this.lblMailState.Name = "lblMailState";
            this.lblMailState.Size = new System.Drawing.Size(70, 13);
            this.lblMailState.TabIndex = 113;
            this.lblMailState.Text = "Correo Valido";
            this.lblMailState.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDNI);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Location = new System.Drawing.Point(303, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 57);
            this.groupBox5.TabIndex = 103;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDNI.Location = new System.Drawing.Point(6, 23);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(163, 22);
            this.txtDNI.TabIndex = 5;
            this.txtDNI.Text = "69.420.911";
            this.txtDNI.Enter += new System.EventHandler(this.txtDNI_Enter);
            this.txtDNI.Leave += new System.EventHandler(this.txtDNI_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNombre);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Location = new System.Drawing.Point(22, 219);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(176, 57);
            this.groupBox6.TabIndex = 102;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(6, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Roberto Gomez";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblTelefonoState
            // 
            this.lblTelefonoState.AutoSize = true;
            this.lblTelefonoState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(177)))), ((int)(((byte)(91)))));
            this.lblTelefonoState.Location = new System.Drawing.Point(485, 323);
            this.lblTelefonoState.Name = "lblTelefonoState";
            this.lblTelefonoState.Size = new System.Drawing.Size(81, 13);
            this.lblTelefonoState.TabIndex = 116;
            this.lblTelefonoState.Text = "Telefono Valido";
            this.lblTelefonoState.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtTelefono);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Location = new System.Drawing.Point(303, 295);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(175, 57);
            this.groupBox8.TabIndex = 105;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nro Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelefono.Location = new System.Drawing.Point(6, 23);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(163, 22);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.Text = "11 4206 9911";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(23, 444);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.ob);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboTipoTel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(22, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 57);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Telefono";
            // 
            // cboTipoTel
            // 
            this.cboTipoTel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTel.FormattingEnabled = true;
            this.cboTipoTel.Items.AddRange(new object[] {
            "Fijo",
            "Movil"});
            this.cboTipoTel.Location = new System.Drawing.Point(6, 23);
            this.cboTipoTel.Name = "cboTipoTel";
            this.cboTipoTel.Size = new System.Drawing.Size(163, 24);
            this.cboTipoTel.TabIndex = 3;
            // 
            // Partido
            // 
            this.Partido.Controls.Add(this.cboPartido);
            this.Partido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Partido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Partido.Location = new System.Drawing.Point(23, 371);
            this.Partido.Name = "Partido";
            this.Partido.Size = new System.Drawing.Size(175, 57);
            this.Partido.TabIndex = 105;
            this.Partido.TabStop = false;
            this.Partido.Text = "Partido";
            // 
            // cboPartido
            // 
            this.cboPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartido.FormattingEnabled = true;
            this.cboPartido.Items.AddRange(new object[] {
            "Fijo",
            "Movil"});
            this.cboPartido.Location = new System.Drawing.Point(6, 21);
            this.cboPartido.Name = "cboPartido";
            this.cboPartido.Size = new System.Drawing.Size(163, 24);
            this.cboPartido.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboLocalidad);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Location = new System.Drawing.Point(303, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 57);
            this.groupBox4.TabIndex = 106;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Localidad";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Items.AddRange(new object[] {
            "Fijo",
            "Movil"});
            this.cboLocalidad.Location = new System.Drawing.Point(6, 21);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(163, 24);
            this.cboLocalidad.TabIndex = 3;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(595, 481);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Partido);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblDniState);
            this.Controls.Add(this.lblTelefonoState);
            this.Controls.Add(this.lblMailState);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.lblNombreState);
            this.Controls.Add(this.lblUserState);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.Partido.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.Label lblNombreState;
        private System.Windows.Forms.Button btnAbrirLogin;
        private System.Windows.Forms.Label lblDniState;
        private System.Windows.Forms.Label lblMailState;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefonoState;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboTipoTel;
        private System.Windows.Forms.GroupBox Partido;
        private System.Windows.Forms.ComboBox cboPartido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboLocalidad;
    }
}