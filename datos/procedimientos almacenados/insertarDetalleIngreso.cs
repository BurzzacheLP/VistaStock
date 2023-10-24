using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.procedimientos_almacenados
{
    public class insertarDetalleIngreso
    {
        public bool EjecutarYDevolver( int idarticulo,int idingreso, int preciocompra, int precioventa, int stockinicial, int stockactual, DateTime fechaproduccion, DateTime fechavencimiento)
        {
            try
            {
                ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@idarticulo", SqlDbType.Int) { Value = idarticulo},
                     new SqlParameter("@idingreso", SqlDbType.Int) { Value = idingreso},
                     new SqlParameter("@precio_compra", SqlDbType.Money) { Value = preciocompra},
                     new SqlParameter("@precio_venta", SqlDbType.Money) { Value = precioventa},
                     new SqlParameter("@stock_inicial", SqlDbType.Int) { Value = stockinicial},
                     new SqlParameter("@stock_actual", SqlDbType.Int) { Value = stockactual},
                     new SqlParameter("@fecha_produccion", SqlDbType.Date) { Value = fechaproduccion},
                     new SqlParameter("@fecha_vencimiento", SqlDbType.Date) { Value = fechavencimiento},
                    
                };
                ejecutar_Procedimientos__Almacenados.EjecutarProcedimiento("spinsertar_detalle_ingreso", parametros);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
