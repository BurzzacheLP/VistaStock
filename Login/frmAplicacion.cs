﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using comun;
using logica;
using servicios;
using Vista;

namespace Login
{
    public partial class frmAplicacion : Form
    {
        public frmAplicacion()
        {
            InitializeComponent();
        }

        private void frmAplicacion_Load(object sender, EventArgs e) 
        {

            if (Comun.FechaFin <= DateTime.Today)
            {
                if (BorrarinfoPersonal.borrar(Comun.UserID)) 
                { 
                    this.Close();
                }
            }

            if (Comun.bloqueado == true)
            {
                BloquearControles.DisableControls(this);
                MessageBox.Show("Este usuario se encuentra Bloqueado");
            }
            else
            {
                BloquearControles.DisableControls(this);
            }

            lblUserName.Text = Comun.NombreUsuario.ToString();

            if (Comun.NombrePermiso == "admin")
            {
                MessageBox.Show("Usted es administrador");
                BloquearControles.EnableControls(btnAdministrador);                
            }
            else
            {
                BloquearControles.DisableControls(btnAdministrador);
            }

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
            panelWorkspace.Controls.Add(frmhijo);
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

        private void lblInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            // Primer caso documentado de yo (lucho perrone) abriendo un formulario adentro de otro
            frmAdmin Admin = new frmAdmin();
            abrirSubForm(Admin);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Cerrar Sesion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd / MM / yyyy | HH:mm:ss");            
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCompras_Click(object sender, EventArgs e)
        {
            Form frmIngresos = new frmIngresos();
            abrirSubForm(frmIngresos);
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            Form frmIngresos = new frmIngresos();
            abrirSubForm(frmIngresos);
        }

        private void lblAlmacen_Click(object sender, EventArgs e)
        {
            Form frmArticulos = new frmArticulos();
            abrirSubForm(frmArticulos);
        }

        private void lblConsulReportes_Click(object sender, EventArgs e)
        {
            Form frmCategoria = new frmCategoria();
            abrirSubForm(frmCategoria);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form frmProveedores = new frmProveedores();
            abrirSubForm(frmProveedores);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form frmTelefonos = new frmTelefonos();
            abrirSubForm(frmTelefonos);
        }
    }
}
