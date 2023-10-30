using logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = creardt.crear();
            dataGridView1.AutoResizeColumns();

            dateCaducidad.MinDate = DateTime.Today;       
        }
    }
}
