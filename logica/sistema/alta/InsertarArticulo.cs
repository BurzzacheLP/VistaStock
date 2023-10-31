using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarArticulo
    {
            public bool insertar(string codigo, string nombre, string descripcion, int idcategoria, int idpresentacion)
            {
                insertarArticulo insertararticulo = new insertarArticulo ();
                return insertararticulo.EjecutarYDevolver(codigo,nombre,descripcion, idcategoria,idpresentacion );
            }
    }
}
