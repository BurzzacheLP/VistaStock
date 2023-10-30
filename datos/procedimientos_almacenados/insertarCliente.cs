using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
   public class insertarCliente
    {
        public bool EjecutarYDevolver(string codigo, string nombre, DateTime fechaNacimiento, string tipodocumento , string numdocumento, string telefono , string gmail, string calle, int altura , string localidad)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = codigo},
                     new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime) { Value = nombre},
                     new SqlParameter("@tipo_documento", SqlDbType.VarChar) { Value = tipodocumento},
                     new SqlParameter("@num_documento", SqlDbType.VarChar) { Value = numdocumento},
                     new SqlParameter("@telefono", SqlDbType.VarChar) { Value = telefono},
                     new SqlParameter("@gmail", SqlDbType.VarChar) { Value = nombre},
                     new SqlParameter("@calle", SqlDbType.VarChar) { Value = calle},
                     new SqlParameter("@altura", SqlDbType.Int) { Value = altura},
                     new SqlParameter("@localidad", SqlDbType.VarChar) { Value = localidad},
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_cliente", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
