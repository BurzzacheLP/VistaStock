using capaConexion;
using Comun;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaConexion.Login
{
    internal class ConectarUsuario : ejecutarConsultasSCP
    {
        public bool verificarUsuario(string user, string pass)
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>();
        
            SqlParameter param1 = new SqlParameter("@user", user)
            {
                SqlDbType = SqlDbType.NVarChar
            };
            listaParametros.Add(param1);
        
            SqlParameter param2 = new SqlParameter("@Pass", pass)
            {
                SqlDbType = SqlDbType.NVarChar
            };
            listaParametros.Add(param2);
        
            DataTable resultado = ejecutarConsultas("Login_LogIn", listaParametros.ToArray());
        
            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    UserCache.IdUsuario = Convert.ToInt32(row[0].ToString());
                    UserCache.Usuario = row[1].ToString();
                    UserCache.Password = row[2].ToString();
                    UserCache.IdPersona = Convert.ToInt32(row[3].ToString());
                    if (!string.IsNullOrEmpty(row[4].ToString())) UserCache.FechaAlta = Convert.ToDateTime(row[4].ToString());
                    if (!string.IsNullOrEmpty(row[5].ToString())) UserCache.FechaBaja = Convert.ToDateTime(row[5].ToString());
                    UserCache.CambiaCada = Convert.ToInt32(row[6].ToString());
                    if (!string.IsNullOrEmpty(row[7].ToString())) UserCache.FechaUltimoCambio = Convert.ToDateTime(row[7].ToString());
                    UserCache.UsuarioDesactivado = Convert.ToBoolean(row[8].ToString()); ;
                    UserCache.Apellido = row[10].ToString();
                    UserCache.Nombres = row[11].ToString();
                   //UserCache.Cargo = row[12].ToString();
                }
                Permisos permiso = new Permisos();
                permiso.buscarPermisos(UserCache.IdUsuario);
        
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
