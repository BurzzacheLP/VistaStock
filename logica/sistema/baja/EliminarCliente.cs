using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.baja
{
    public class EliminarCliente
    {
        public bool eliminar(int idcliente)
        {
            eliminarCliente eliminarcliente = new eliminarCliente();
            return eliminarcliente.EjecutarYDevolver(idcliente);
        }
    }
}
