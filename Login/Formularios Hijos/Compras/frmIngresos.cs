using logica;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmIngresos : Form
    {
        public int IdTrabajador;
        private bool IsNuevo;

        private DataTable dtDetalle;

        private decimal totalPagado = 0;


        


        public frmIngresos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            // Hacer que una vez que se apliquen los filtros se carguen los datos del data grid
        }
    }
}
