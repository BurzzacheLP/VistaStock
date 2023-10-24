using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class insertarArticulo
    {

        public bool EjecutarYDevolver(string codigo,string nombre, string descripcion,int idcategoria,int idpresentacion)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo},
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre},
                     new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion},
                     new SqlParameter("@idcategoria", SqlDbType.Int) { Value = idcategoria},
                      new SqlParameter("@idpresentacion", SqlDbType.Int) { Value = idpresentacion},
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_articulo", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
