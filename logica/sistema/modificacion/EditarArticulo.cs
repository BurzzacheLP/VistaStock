using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public class EditarArticulo
    {
        public bool editar(int idarticulo,string codigo, string nombre, string descripcion, string categoria, string presentacion)
        {
            editarArticulo editararticulo = new editarArticulo();
            return editararticulo.EjecutarYDevolver(idarticulo, codigo, nombre, descripcion, categoria, presentacion);
        }
    }
}
