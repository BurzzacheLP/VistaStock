using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public class EditarPresentacion
    {
        public bool editar(int idpresentacion, string nombre, string descripcion)
        {
            editarPresentacion editarpresentacion = new editarPresentacion();
            return editarpresentacion.EjecutarYDevolver(idpresentacion, nombre, descripcion);
        }

    }
}
