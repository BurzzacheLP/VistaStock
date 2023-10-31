using datos.procedimientos_almacenados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.sistema.baja
{
    public class EliminarProveedor
    {
        public bool eliminar(int idproveedor)
        {
            eliminarProveedor eliminarproveedor = new eliminarProveedor();
            return eliminarproveedor.EjecutarYDevolver(idproveedor);
        }
    }
}
