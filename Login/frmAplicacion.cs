using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login
{
    public partial class frmAplicacion : Form
    {
        public frmAplicacion()
        {
            InitializeComponent();
        }

        private void abrirSubForm(Form frmhijo)
        {
            if (FormActual != null)
            {
                FormActual.Dispose();
            }

            FormActual = frmhijo;
            frmhijo.Show();
            frmhijo.BringToFront();

            frmhijo.TopLevel = false;
            frmhijo.FormBorderStyle = FormBorderStyle.None;
            frmhijo.Dock = DockStyle.Fill;

            lblTitulo.Tag = frmhijo;
            lblTitulo.Text = frmhijo.Text;

        }

        private void abrirCerrarSubMenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                subMenuActual = submenu;
                cerrarSubMenu();

                if (submenu.Visible == true)
                {
                    submenu.Visible = false;
                    submenu.Enabled = false;
                }
                else
                {
                    submenu.Visible = true;
                    submenu.Enabled = true;
                }
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void cerrarSubMenu()
        {
            if (subMenuActual != null)
            {
                subMenuActual.Visible = false;
            }
        }

        #region Variables

        private Panel subMenuActual;
        private Form FormActual;

        #endregion 

        #region Cosas para arrastrar la interfaz
        // Yo se q no queria q copie el codigo este pero me parece util
        // Copiado de https://stackoverflow.com/a/19491283

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            abrirSubForm(new frmGridUsuarios());
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
