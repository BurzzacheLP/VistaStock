using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.baja
{
    public class EliminarCategoria
    {
        public bool eliminar(int idarticulo)
        {
            eliminarCategoria eliminarcategoria = new eliminarCategoria();
            return eliminarcategoria.EjecutarYDevolver(idarticulo);
        }
    }
}
