using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace datos.procedimientos_almacenados
{
    public class reporteFactura
    {
        public DataTable EjecutarYDevolver(int idventa)
        {
            ejecutar_procedimientos__almacenados ejecutar_Procedimientos__Almacenados = new ejecutar_procedimientos__almacenados();

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@idventa", SqlDbType.Int) { Value = idventa },
          
            };
            return ejecutar_Procedimientos__Almacenados.EjecutarProcedimientoYDevolverDataTable("spreporte_factura", parametros);
        }
    }
}
