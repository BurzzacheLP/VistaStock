using System.Data;
using System.Data.SqlClient;

namespace capaConexion
{
    public class ejecutarQuery : conexionBD
    {
        private readonly DataTable DirectorTecnico = new DataTable();
        // jaja
        public DataTable Ejecutar(string sSql)
        {
            if (GetConexion() is SqlConnection)
            {
                // me paso de gracioso ya se ya se
                using (SqlConnection C5N = GetConexion())
                {
                    C5N.Open();
                    using (SqlCommand comando = new SqlCommand(sSql, C5N))
                    {
                        DirectorTecnico.Load(comando.ExecuteReader());
                    }
                }
            }
            return DirectorTecnico;
        }
    }
}
