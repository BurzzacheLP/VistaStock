using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarDetalleVenta
    {
        public bool insertar(int idventa, int iddetalleingreso, int precioventa, int calidad)
        {
            insertarDetalleVenta insertardetalleventa = new insertarDetalleVenta();
            return insertardetalleventa.EjecutarYDevolver(idventa, iddetalleingreso, precioventa, calidad);
        }
    }
}
