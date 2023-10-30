using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class editarCliente
    {
        public bool EjecutarYDevolver(int idcliente, int personaid, int idtelefono, int gmailid, int idlocalidad,string nombre, DateTime fechadenacimiento , string tipodocumento, string numdocumento, int altura, string calle, string telefono, string gmail)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idcliente", SqlDbType.Int) { Value = idcliente },
                     new SqlParameter("@personaID", SqlDbType.Int) { Value =personaid},
                     new SqlParameter("@idtelefono", SqlDbType.Int) { Value = idtelefono },
                     new SqlParameter("@gmailid", SqlDbType.Int) { Value = gmailid },
                     new SqlParameter("@idlocalidad", SqlDbType.Int) { Value = idlocalidad },
                     new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                     new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime) { Value = fechadenacimiento },
                     new SqlParameter("@tipo_documento", SqlDbType.VarChar) { Value =tipodocumento},
                     new SqlParameter("@num_documento", SqlDbType.VarChar) { Value = numdocumento },
                     new SqlParameter("@altura", SqlDbType.Int) { Value = altura},
                     new SqlParameter("@calle", SqlDbType.VarChar) { Value = calle },
                     new SqlParameter("@telefono", SqlDbType.VarChar) { Value = telefono },
                     new SqlParameter("@gamil", SqlDbType.VarChar) { Value = gmail},
                     
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("speditar_cliente", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
