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
    public class MostrarProveedor
    {
        public DataTable mostrar()
        {
            mostrarProveedor mostrarproveedor = new mostrarProveedor();
            return mostrarproveedor.EjecutarYDevolver();
        }
    }
}
