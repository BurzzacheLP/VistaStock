using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public class DisminuirStock
    {
        public bool disminuir(int iddetale_ingreso,int cantidad )
        {
           disminuirStock disminuirstock = new disminuirStock();
            return disminuirstock.EjecutarYDevolver(iddetale_ingreso,cantidad);
        }
    }
}
