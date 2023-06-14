﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //txtPass.UseSystemPasswordChar = false;
        }

        #region Cosas para arrastrar la interfaz
        // Yo se q no queria q copie el codigo este pero me parece util
        // Copiado de https://stackoverflow.com/a/19491283

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Controles de Ventana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region TextBoxes
        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtUser.ForeColor = Color.FromArgb(90, 92, 230);
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario123";
                txtUser.ForeColor = Color.FromArgb(191, 205, 219);
            }
            else
            {
                txtUser.ForeColor = Color.FromArgb(39, 39, 39);
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtPass.ForeColor = Color.FromArgb(90, 92, 230);
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {

            if (txtPass.Text == "")
            {
                txtPass.Text = "Usuario123";
                txtPass.ForeColor = Color.FromArgb(191, 205, 219);
            }
            else
            {
                txtPass.ForeColor = Color.FromArgb(39, 39, 39);
            }
        }


        #endregion

        #region Mostrar Contraseña
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }
        #endregion

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblOlvido_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
