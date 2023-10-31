using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarPresentacion
    {
        public bool insertar(int idpresentacion, string nombre, string descripcion)
        {
            insertarPresentacion insertarpresentacion = new insertarPresentacion();
            return insertarpresentacion.EjecutarYDevolver(idpresentacion, nombre, descripcion);
        }
    }
}
