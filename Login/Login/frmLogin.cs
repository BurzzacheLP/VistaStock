using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
using comun;
using Vista;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ObtenerConfigSis.obtener();
        }

        /*
        #region Cosas para arrastrar la interfaz
        // Yo se q no queria q copie el codigo este pero me parece util
        // Copiado de https://stackoverflow.com/a/19491283

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

    
        //[DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    
        #endregion
        */

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
            txtUser.ForeColor = Color.FromArgb(90, 92, 230);
            if (txtUser.Text == "Usuario123")
            {
                txtUser.Clear();
            }
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
            txtPass.UseSystemPasswordChar = true;
            txtPass.ForeColor = Color.FromArgb(90, 92, 230);
            if (txtPass.Text == "Contraseña456")
            {
                txtPass.Clear();
            }
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
        private void picShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar =! txtPass.UseSystemPasswordChar;
            //picShow.
        }

        #endregion

        /*
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                
            }
        }
        */

        private void lblOlvido_Click(object sender, EventArgs e)
        {
            frmOlvido Olvido = new frmOlvido();
            Olvido.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool validar = true;

            // Chequear si el campo de usuario tiene texto
            if(string.IsNullOrEmpty(txtUser.Text) || txtUser.Text == "Usuario123")
            {
                lblErrorUsr.Visible = true;
                lblErrorUsr.Text = "Por favor rellene el campo";
                validar = false;
            }

            // Chequear si el campo de contraseña tiene texto
            if(string.IsNullOrEmpty(txtPass.Text) || txtPass.Text == "Contraseña456")
            {
                lblErrorPass.Visible = true;
                lblErrorPass.Text = "Por favor rellene el campo";
                validar = false;
            }

            if (validar == true)
            {
                consultarlogueo cl = new consultarlogueo();
                
                if (cl.preguntar(txtUser.Text, txtPass.Text))
                {
                    switch (Comun.NombrePermiso)
                    {
                        case "admin":
                            // Nota; Hacer que el boton de Administrador
                            // se muestre solo si el usuario es admin
                            frmAplicacion frmApp = new frmAplicacion();
                            frmApp.Show();
                            break;

                        case "compras":                        
                        case "ventas":
                            frmAplicacion Apliacion = new frmAplicacion();
                            Apliacion.Show();
                            break;
                        case "persona":
                            MessageBox.Show("El usuario no tiene permisos");
                            break;

                    }
                    this.Hide();
                }
                else
                {
                    lblErrorUsr.Visible = true;
                    lblErrorUsr.Text = "Nombre de Usuario Inexistente";
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
