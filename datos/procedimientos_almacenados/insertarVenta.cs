using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class insertarVenta
    {
        public bool EjecutarYDevolver(int idcliente, int UserID, DateTime fecha, string tipocomprobante)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idcliente", SqlDbType.Int) { Value = idcliente},
                     new SqlParameter("@UserID", SqlDbType.Int) { Value = UserID},
                     new SqlParameter("@fecha", SqlDbType.Date) { Value = fecha},
                        new SqlParameter("@tipo_comprobante", SqlDbType.VarChar) { Value = tipocomprobante},
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_venta", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
