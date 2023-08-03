using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaConexion.Login
{
    public class BloquearUsuario : ejecutarConsultasSCP
    {
        public void bloquearUsuario(int IdUser)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();

            SqlParameter param1 = new SqlParameter("@IdUser", IdUser)
            {
                SqlDbType = SqlDbType.Int
            };
            listaParametros.Add(param1);
            _ = ejecutarConsultas("Login_BloquearUsuario", listaParametros.ToArray(), true);
        }
    }
}
