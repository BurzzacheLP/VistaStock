using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.baja
{
    public class EliminarVenta
    {
        public bool eliminar(int idventa)
        {
            eliminarVenta eliminarventa = new eliminarVenta();
            return eliminarventa.EjecutarYDevolver(idventa);
        }
    }
}
