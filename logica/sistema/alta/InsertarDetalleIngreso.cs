using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarDetalleIngreso
    {
        public bool insertar(int idarticulo, int idingreso, int preciocompra, int precioventa, int stockinicial, int stockactual, DateTime fechaproduccion, DateTime fechavencimiento)
        {
            insertarDetalleIngreso insertardetalleingreso = new insertarDetalleIngreso();
            return insertardetalleingreso.EjecutarYDevolver(idarticulo, idingreso, preciocompra, precioventa, stockinicial, stockactual, fechaproduccion, fechavencimiento);

        }
    }
}
