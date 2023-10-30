using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class eliminarCategoria
    {
        public bool EjecutarYDevolver(int idcategoria)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idcategoria", SqlDbType.Int) { Value = idcategoria},

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
