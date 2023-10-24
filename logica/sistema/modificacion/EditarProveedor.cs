using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public class EditarProveedor
    {
        public bool editar(int personaid, string telefonoid, string gmailid, int idproveedor, string nombre, string razonSocial, string sectorComercial, string tipoDocumento, string numDocumento, string calle, int altura, string telefono, string gmail)
        {
            editarProveedor editarproveedor = new editarProveedor();
            return editarproveedor.EjecutarYDevolver( personaid, telefono, gmailid, idproveedor, nombre, razonSocial, sectorComercial, tipoDocumento, numDocumento, calle, altura, telefono, gmail);
        }
    }
}
