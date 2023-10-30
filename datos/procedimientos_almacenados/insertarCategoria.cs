using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class insertarCategoria
    {
        public bool EjecutarYDevolver(string nombre,  string descripcion)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                   
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre},
                     new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion},

                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_categoria", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
