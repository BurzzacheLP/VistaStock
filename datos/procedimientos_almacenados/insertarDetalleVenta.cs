using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class insertarDetalleVenta
    {
        public bool EjecutarYDevolver(int idventa, int iddetalleingreso, int precioventa,int cantidad)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idventa", SqlDbType.Int) { Value = idventa},
                     new SqlParameter("@iddetalle_ingreso", SqlDbType.Int) { Value = iddetalleingreso},
                     new SqlParameter("@precio_venta", SqlDbType.Money) { Value =precioventa},
                     new SqlParameter("@cantidad", SqlDbType.Int) { Value = cantidad},
                   
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_detalle_venta", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
