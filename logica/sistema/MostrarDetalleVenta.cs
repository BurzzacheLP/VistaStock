using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema
{
    public class MostrarDetalleVenta
    {
        public DataTable mostrar()
        {
            datos.procedimientos_almacenados.MostrarDetalleVenta mostrardetalleventa = new datos.procedimientos_almacenados.MostrarDetalleVenta();
            return mostrardetalleventa.EjecutarYDevolver();
        }

    }
}