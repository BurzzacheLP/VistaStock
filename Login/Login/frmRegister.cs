using logica;
using servicios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vista.Controles;

namespace Login
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        #region Drag

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region TxtBoxes
    
            #region TxtUser
            private void txtUser_Enter(object sender, EventArgs e)
            {
                cambiosControles.placeHolder_Set(txtUser, "Usuario123");
            }

            private void txtUser_Leave(object sender, EventArgs e)
            {
                cambiosControles.placeHolder_Reset(txtUser, "Usuario123");
            }
        }

            #endregion
    
            #region txtMail
        private void txtMail_Enter(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Set(txtTelefono, "correo@mail.com");
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            cambiosControles.placeHolder_Reset(txtMail, "correo@gmail.com");
        }

        #endregion
    
            #region txtNombre
            private void txtNombre_Enter(object sender, EventArgs e)
            {
                cambiosControles.placeHolder_Set(txtNombre, "Roberto Gomez");
            }
    
            private void txtNombre_Leave(object sender, EventArgs e)
            {
                cambiosControles.placeHolder_Reset(txtNombre, "Roberto Gomez");
            }
            #endregion
    
    
            #region txtDNI
            private void txtDNI_Enter(object sender, EventArgs e)
            {
                cambiosControles.placeHolder_Set(txtDNI, "69.420.911");
            }
    
            private void txtDNI_Leave(object sender, EventArgs e)
            { 
                cambiosControles.placeHolder_Reset(txtDNI, "69.420.911");               
            }
    
            #endregion
    
            #region txtTelefono
            private void txtTelefono_Enter(object sender, EventArgs e)
            {
                cambiosControles.placeHolder_Set(txtTelefono, "11 4206 9911");
            }
    
    
            private void txtTelefono_Leave(object sender, EventArgs e)
            {
                cambiosControles.placeHolder_Reset(txtTelefono, "11 4206 9911");
            }
            #endregion

        #endregion

        #region ControlesVentana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnAbrirLogin_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void ob(object sender, EventArgs e)
        {

        }
    }
}
