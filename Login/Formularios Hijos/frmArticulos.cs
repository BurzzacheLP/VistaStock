using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmArticulos : Form
    {
        private bool IsNuevo = false;
        private bool IsEditable = false;

        public void setCategoria(string idCategoria, string nombre)
        {
            this.txtCategoriaId.Text = idCategoria;
            this.cboCategoria.Text = nombre;
        }

        public frmArticulos()
        {
            InitializeComponent();

            // Tooltips
            // To Do

            this.txtCategoriaId.Visible = true;
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Cargar una foto

            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.imgPresentacion.SizeMode = PictureBoxSizeMode.StretchImage;
                imgPresentacion.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.imgPresentacion.Dispose();
        }
    }
}
