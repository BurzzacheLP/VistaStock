using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class disminuirStock
    {
        public bool EjecutarYDevolver(int iddetalle_ingreso, int cantidad)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@iddetalle_ingreso", SqlDbType.Int) { Value = iddetalle_ingreso },
                     new SqlParameter("@cantidad", SqlDbType.Int) { Value = cantidad},
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spdisminuir_stock", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
