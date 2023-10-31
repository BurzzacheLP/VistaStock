using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarCategoria
    {
        public bool insertar(string nombre, string descripcion)
        {
            insertarCategoria insertarcategoria = new insertarCategoria();
            return insertarcategoria.EjecutarYDevolver(nombre, descripcion);
        }

    }
}
