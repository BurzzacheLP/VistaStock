using System.Data.SqlClient;

namespace capaConexion
{
    public abstract class conexionBD
    {
        private const string cadena = "data source = TOSTADORA3\\SQLEXPRESS; database = Login; integrated security = true "
        protected SqlConnection GetConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
