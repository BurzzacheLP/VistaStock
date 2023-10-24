using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;
    
namespace logica.sistema.baja
{
    public class EliminarArticulo
    {
        public bool eliminar (int idarticulo)
        {
            eliminarArticulo  eliminararticulo = new  eliminarArticulo();
            return eliminararticulo.EjecutarYDevolver(idarticulo);
        }
    }
}
