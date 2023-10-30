using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class editar_categoria
    {
        public bool EjecutarYDevolver(int idcategoria, string nombre, string descripcion)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idcategoria", SqlDbType.Int) { Value = idcategoria },
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                     new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion },
                 
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speditar_categoria", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
