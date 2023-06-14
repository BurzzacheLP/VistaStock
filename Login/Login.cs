using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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

        
    }
}
