using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace capaConexion.Login
{
    public class TraerPersona : ejecutarConsultasSCP
    {
        readonly List<SqlParameter> listaParametros = new List<SqlParameter>();
        public DataTable DTTraerPersona(string user)
        {
            SqlParameter param1 = new SqlParameter("@user", user)
            {
                SqlDbType = SqlDbType.NVarChar
            };
            listaParametros.Add(param1);
            return ejecutarConsultas("Login_TraerPersona", listaParametros.ToArray());
        }
    }
}
