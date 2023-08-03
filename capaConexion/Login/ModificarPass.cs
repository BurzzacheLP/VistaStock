using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace capaConexion.Login
{
    public class ModificarPass : ejecutarConsultasSCP
    {
        public void ModificaPass(int IdUser, String Pass, bool PassNueva, int CodVerif)
        {

            List<SqlParameter> listaParametros = new List<SqlParameter>();

            SqlParameter param1 = new SqlParameter("@IdUser", IdUser)
            {
                SqlDbType = SqlDbType.Int
            };
            listaParametros.Add(param1);

            SqlParameter param2 = new SqlParameter("@Pass", Pass)
            {
                SqlDbType = SqlDbType.NVarChar
            };
            listaParametros.Add(param2);

            SqlParameter param3 = new SqlParameter("@PassNueva", PassNueva)
            {
                SqlDbType = SqlDbType.Bit
            };
            listaParametros.Add(param3);

            SqlParameter param4 = new SqlParameter("@CodVerif", CodVerif)
            {
                SqlDbType = SqlDbType.Bit
            };
            listaParametros.Add(param4);

            _ = ejecutarConsultas("Login_CambiarPassword", listaParametros.ToArray(), true);
        }
    }
}
}
