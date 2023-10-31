using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.baja
{
    public class EliminarPresentacion
    {
        public bool eliminar(int idpresentacion)
        {
            eliminarPresentacion eliminarpresentacion = new eliminarPresentacion();
            return eliminarpresentacion.EjecutarYDevolver(idpresentacion);
        }
    }
}
