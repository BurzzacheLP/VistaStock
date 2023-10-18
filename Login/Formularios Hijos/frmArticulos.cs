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

        private void frmArticulos_Load(object sender, EventArgs e)
        {

        }
    }
}
