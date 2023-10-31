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
    public  class Editar_Categoria
    {
        public bool editar (int idcategoria, string nombre, string descripcion)
        {
            editar_categoria editar_Categoria = new editar_categoria ();
            return editar_Categoria.EjecutarYDevolver(idcategoria, nombre, descripcion); 
        }
    }
}
