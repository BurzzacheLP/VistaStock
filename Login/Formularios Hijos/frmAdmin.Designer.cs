namespace Vista
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboRepeat = new System.Windows.Forms.CheckBox();
            this.cbo2FA = new System.Windows.Forms.CheckBox();
            this.cboSpecChar = new System.Windows.Forms.CheckBox();
            this.cboCaps = new System.Windows.Forms.CheckBox();
            this.cboMinChar = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateCaducidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.groupBox1.Location = new System.Drawing.Point(400, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar Usuarios";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(33, 218);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(77, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Bloqueado";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Caducidad";
            // 
            // dateCaducidad
            // 
            this.dateCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCaducidad.Location = new System.Drawing.Point(33, 192);
            this.dateCaducidad.Name = "dateCaducidad";
            this.dateCaducidad.Size = new System.Drawing.Size(95, 20);
            this.dateCaducidad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Permisos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Usuario";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(33, 91);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(173, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(33, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(173, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboRepeat);
            this.groupBox2.Controls.Add(this.cbo2FA);
            this.groupBox2.Controls.Add(this.cboSpecChar);
            this.groupBox2.Controls.Add(this.cboCaps);
            this.groupBox2.Controls.Add(this.cboMinChar);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.groupBox2.Location = new System.Drawing.Point(674, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 147);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurar Sistema";
            // 
            // cboRepeat
            // 
            this.cboRepeat.AutoSize = true;
            this.cboRepeat.Location = new System.Drawing.Point(16, 117);
            this.cboRepeat.Name = "cboRepeat";
            this.cboRepeat.Size = new System.Drawing.Size(122, 17);
            this.cboRepeat.TabIndex = 4;
            this.cboRepeat.Text = "Repetir Contraseñas";
            this.cboRepeat.UseVisualStyleBackColor = true;
            // 
            // cbo2FA
            // 
            this.cbo2FA.AutoSize = true;
            this.cbo2FA.Location = new System.Drawing.Point(16, 94);
            this.cbo2FA.Name = "cbo2FA";
            this.cbo2FA.Size = new System.Drawing.Size(152, 17);
            this.cbo2FA.TabIndex = 3;
            this.cbo2FA.Text = "Autentificacion en 2 Pasos";
            this.cbo2FA.UseVisualStyleBackColor = true;
            // 
            // cboSpecChar
            // 
            this.cboSpecChar.AutoSize = true;
            this.cboSpecChar.Location = new System.Drawing.Point(16, 71);
            this.cboSpecChar.Name = "cboSpecChar";
            this.cboSpecChar.Size = new System.Drawing.Size(130, 17);
            this.cboSpecChar.TabIndex = 2;
            this.cboSpecChar.Text = "Caracteres especiales";
            this.cboSpecChar.UseVisualStyleBackColor = true;
            // 
            // cboCaps
            // 
            this.cboCaps.AutoSize = true;
            this.cboCaps.Location = new System.Drawing.Point(16, 48);
            this.cboCaps.Name = "cboCaps";
            this.cboCaps.Size = new System.Drawing.Size(146, 17);
            this.cboCaps.TabIndex = 1;
            this.cboCaps.Text = "Mayusculas y Minusculas";
            this.cboCaps.UseVisualStyleBackColor = true;
            // 
            // cboMinChar
            // 
            this.cboMinChar.AutoSize = true;
            this.cboMinChar.Location = new System.Drawing.Point(16, 25);
            this.cboMinChar.Name = "cboMinChar";
            this.cboMinChar.Size = new System.Drawing.Size(128, 17);
            this.cboMinChar.TabIndex = 0;
            this.cboMinChar.Text = "Minimo de Caracteres";
            this.cboMinChar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(362, 404);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Location = new System.Drawing.Point(68, 505);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 60);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(196, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(19, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(78, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(137, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(465, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 60);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(70, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(6, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Location = new System.Drawing.Point(739, 245);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(118, 60);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(70, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(6, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(935, 575);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DateTimePicker dateCaducidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cboRepeat;
        private System.Windows.Forms.CheckBox cbo2FA;
        private System.Windows.Forms.CheckBox cboSpecChar;
        private System.Windows.Forms.CheckBox cboCaps;
        private System.Windows.Forms.CheckBox cboMinChar;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}