using Comun;
using capaConexion.Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace capaConexion.Login
{
    public class Permisos : ejecutarConsultasSCP
    {
        public bool buscarPermisos(int IdUser)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();

            SqlParameter param1 = new SqlParameter("@IdUser", IdUser)
            {
                SqlDbType = SqlDbType.Int
            };
            listaParametros.Add(param1);

            DataTable resultado = ejecutarConsultas("Login_PermisosUsiario", listaParametros.ToArray());

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    UserCache.PermisoUsuario.Add(Convert.ToInt32(row[0].ToString()), row[1].ToString());
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
