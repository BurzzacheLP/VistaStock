using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarCliente
    {
        public bool insertar(string codigo, string nombre, DateTime fechaNacimiento, string tipodocumento, string numdocumento, string telefono, string gmail, string calle, int altura, string localidad)
        {
            insertarCliente insertarcliente = new insertarCliente();
            return insertarcliente.EjecutarYDevolver(codigo, nombre, fechaNacimiento, tipodocumento, numdocumento, telefono, gmail, calle, altura, localidad);
        }
    }
}
