using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.FromArgb(90, 92, 230);
            if (txtUser.Text == "Usuario123")
            {
                txtUser.Clear();
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            txtMail.ForeColor = Color.FromArgb(90, 92, 230);
            if (txtMail.Text == "correo@mail.com")
            {
                txtMail.Clear();
            }
        }

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
    }
}
