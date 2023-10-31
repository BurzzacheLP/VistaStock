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
    public class MostrarCliente
    {
        public DataTable mostrar()
        {
            mostrarCliente mostrarcliente = new mostrarCliente();
            return mostrarcliente.EjecutarYDevolver();
        }
    }
}
