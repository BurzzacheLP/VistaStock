﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema
{
    public class MostrarCategoria
    {
        public DataTable mostrar()
        {
            mostrarCategoria mostrarcategoria = new mostrarCategoria();
            return mostrarcategoria.EjecutarYDevolver();
        }
    }
}