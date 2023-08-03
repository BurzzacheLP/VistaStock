using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace capaConexion.Login
{
    public class BuscarUser : ejecutarConsultasSCP
    {
        readonly List<SqlParameter> listaParametros = new List<SqlParameter>();
        public int CDbuscarUser(string user)
        {
            SqlParameter param1 = new SqlParameter("@user", user)
            {
                SqlDbType = SqlDbType.NVarChar
            };
            listaParametros.Add(param1);

            DataTable resultado = ejecutarConsultas("Login_User", listaParametros.ToArray());
            int Id = (int)resultado.Rows[0][0];

            return Id;
        }
    }
}
