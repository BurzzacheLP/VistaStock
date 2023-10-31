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
    public partial class frmTelefonos : Form
    {
        public frmTelefonos()
        {
            InitializeComponent();
        }

        // Reemplazar por la clase de logica correspondiente
        DataTable DTTelefonos = new DataTable();

        private void frmTelefonos_Load(object sender, EventArgs e)
        {
            dataGridListado.DataSource = DTTelefonos;
        }
    }
}
