using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class editarArticulo
    {
        public bool EjecutarYDevolver(int idarticulo, string codigo,string nombre, string descripcion,string idcategoria, string idpresentacion)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idarticulo", SqlDbType.Int) { Value = idarticulo },
                     new SqlParameter("@codigo", SqlDbType.VarChar) { Value = codigo },
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                     new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion },
                     new SqlParameter("@idcategoria", SqlDbType.Int) { Value = idcategoria },
                     new SqlParameter("@idpresentacion", SqlDbType.Int) { Value = idpresentacion },

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speditar_articulo", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
