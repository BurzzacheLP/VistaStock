using capaConexion.Login;
using Comun;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace capaConexion.Bitacora
{
    public class Bitacora : ejecutarConsultasSCP
    {
        public Bitacora(string evento, string detallito, string aborigen, int IdUser = 0) 
        {
            if (IdUser == 0) 
            {
                IdUser = UserCache.IdUsuario;
            }

            List<SqlParameter> listaParametros = new List<SqlParameter>();

            SqlParameter param1 = new SqlParameter("@IdUser", IdUser)
            {
                SqlDbType = SqlDbType.Int
            };
            listaParametros.Add(param1);

            SqlParameter param2 = new SqlParameter("@Evento", evento)
            {
                SqlDbType = SqlDbType.NVarChar
            };
            listaParametros.Add(param2);

            SqlParameter param3 = new SqlParameter("@Detalle", detallito);
            param2.SqlDbType = SqlDbType.NVarChar;
            listaParametros.Add(param3);

            SqlParameter param4 = new SqlParameter("@Origen", aborigen);
            param2.SqlDbType= SqlDbType.NVarChar;
            listaParametros.Add(param4);
           
            _ = ejecutarConsultas("Bitacora_GuardarEventos", listaParametros.ToArray(), true);
            
        }

    }
}
