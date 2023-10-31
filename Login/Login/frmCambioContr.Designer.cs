namespace Vista
{
    partial class frmCambioContr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblActualState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContraNuevaState = new System.Windows.Forms.Label();
            this.lblMatchError = new System.Windows.Forms.Label();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.txtContraNueva = new System.Windows.Forms.TextBox();
            this.txtRepetirActual = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambio de Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(96, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Actual";
            // 
            // lblActualState
            // 
            this.lblActualState.AutoSize = true;
            this.lblActualState.ForeColor = System.Drawing.Color.Red;
            this.lblActualState.Location = new System.Drawing.Point(129, 78);
            this.lblActualState.Name = "lblActualState";
            this.lblActualState.Size = new System.Drawing.Size(29, 13);
            this.lblActualState.TabIndex = 2;
            this.lblActualState.Text = "Error";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label4.Location = new System.Drawing.Point(96, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña Nueva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label5.Location = new System.Drawing.Point(76, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repetir Contraseña Nueva";
            // 
            // lblContraNuevaState
            // 
            this.lblContraNuevaState.AutoSize = true;
            this.lblContraNuevaState.ForeColor = System.Drawing.Color.Red;
            this.lblContraNuevaState.Location = new System.Drawing.Point(129, 206);
            this.lblContraNuevaState.Name = "lblContraNuevaState";
            this.lblContraNuevaState.Size = new System.Drawing.Size(29, 13);
            this.lblContraNuevaState.TabIndex = 5;
            this.lblContraNuevaState.Text = "Error";
            // 
            // lblMatchError
            // 
            this.lblMatchError.AutoSize = true;
            this.lblMatchError.ForeColor = System.Drawing.Color.Red;
            this.lblMatchError.Location = new System.Drawing.Point(37, 268);
            this.lblMatchError.Name = "lblMatchError";
            this.lblMatchError.Size = new System.Drawing.Size(214, 13);
            this.lblMatchError.TabIndex = 6;
            this.lblMatchError.Text = "La contraseña no cumple con los requisitos!";
            // 
            // txtContraActual
            // 
            this.txtContraActual.Location = new System.Drawing.Point(78, 55);
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.Size = new System.Drawing.Size(130, 20);
            this.txtContraActual.TabIndex = 7;
            // 
            // txtContraNueva
            // 
            this.txtContraNueva.Location = new System.Drawing.Point(79, 124);
            this.txtContraNueva.Name = "txtContraNueva";
            this.txtContraNueva.Size = new System.Drawing.Size(130, 20);
            this.txtContraNueva.TabIndex = 8;
            // 
            // txtRepetirActual
            // 
            this.txtRepetirActual.Location = new System.Drawing.Point(77, 183);
            this.txtRepetirActual.Name = "txtRepetirActual";
            this.txtRepetirActual.Size = new System.Drawing.Size(130, 20);
            this.txtRepetirActual.TabIndex = 9;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(89, 242);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(110, 23);
            this.btnCambiar.TabIndex = 10;
            this.btnCambiar.Text = "Cambiar Contraseña";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmCambioContr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(293, 294);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtRepetirActual);
            this.Controls.Add(this.txtContraNueva);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.lblMatchError);
            this.Controls.Add(this.lblContraNuevaState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblActualState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioContr";
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblActualState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContraNuevaState;
        private System.Windows.Forms.Label lblMatchError;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.TextBox txtContraNueva;
        private System.Windows.Forms.TextBox txtRepetirActual;
        private System.Windows.Forms.Button btnCambiar;
    }
}