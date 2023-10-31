using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.alta
{
    public class InsertarIngreso
    {
        public bool insertar(int userid, int idproveedor, DateTime fecha, string tipocomprobante)
        {
            insertarIngreso insertaringreso = new insertarIngreso();
            return insertaringreso.EjecutarYDevolver(userid, idproveedor, fecha, tipocomprobante);
        }
    }
}
