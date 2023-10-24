using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
   public class insertarIngreso
    {
        public bool EjecutarYDevolver(int userid, int idproveedor, DateTime fecha, string tipocomprobante)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@UserID", SqlDbType.Int { Value = userid},
                     new SqlParameter("@idproveedor", SqlDbType.Int) { Value = idproveedor},
                     new SqlParameter("@fecha", SqlDbType.Date) { Value = fecha},
                     new SqlParameter("@tipo_comprobante", SqlDbType.VarChar) { Value = tipocomprobante},
                    
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_ingreso", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
