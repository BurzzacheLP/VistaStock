namespace Vista
{
    partial class frmVerificacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRespuestaState = new System.Windows.Forms.Label();
            this.lblReenviar = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recibiste un correo con el codigo de Verificacion \r\npara realizar el cambio de co" +
    "ntraseña!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRespuestaState
            // 
            this.lblRespuestaState.AutoSize = true;
            this.lblRespuestaState.ForeColor = System.Drawing.Color.Red;
            this.lblRespuestaState.Location = new System.Drawing.Point(120, 82);
            this.lblRespuestaState.Name = "lblRespuestaState";
            this.lblRespuestaState.Size = new System.Drawing.Size(29, 13);
            this.lblRespuestaState.TabIndex = 1;
            this.lblRespuestaState.Text = "Error";
            // 
            // lblReenviar
            // 
            this.lblReenviar.AutoSize = true;
            this.lblReenviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblReenviar.Location = new System.Drawing.Point(91, 160);
            this.lblReenviar.Name = "lblReenviar";
            this.lblReenviar.Size = new System.Drawing.Size(86, 13);
            this.lblReenviar.TabIndex = 2;
            this.lblReenviar.Text = "Reenviar Codigo";
            this.lblReenviar.Visible = false;
            this.lblReenviar.Click += new System.EventHandler(this.lblReenviar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(64, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(97, 106);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblTiempo.Location = new System.Drawing.Point(120, 138);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(22, 13);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "--:--";
            // 
            // frmVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(269, 186);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblReenviar);
            this.Controls.Add(this.lblRespuestaState);
            this.Controls.Add(this.label1);
            this.Name = "frmVerificacion";
            this.Text = "frmVerificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRespuestaState;
        private System.Windows.Forms.Label lblReenviar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTiempo;
    }
}