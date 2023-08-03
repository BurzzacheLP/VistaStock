using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace capaConexion.Login
{
    public class ConsultarLogueos : ejecutarConsultasSCP
    {
        public int Buscar(int idUser)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();

            SqlParameter param1 = new SqlParameter("@IdUser", idUser)
            {
                SqlDbType = SqlDbType.Int
            };
            listaParametros.Add(param1);

            DataTable resultado = ejecutarConsultas("Login_CantLogError", listaParametros.ToArray());

            int Id = (int)resultado.Rows[0][0];

            return Id;
        }
    }
}
