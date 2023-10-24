using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public class EditarCliente
    {
        public bool editar(int idcliente, int personaid, int idtelefono, int gmailid, int idlocalidad, string nombre, DateTime fechadenacimiento, string tipodocumento, string numdocumento, int altura, string calle, string telefono, string gmail)
        {
            editarCliente editarcliente = new editarCliente();
            return editarcliente.EjecutarYDevolver(idcliente, personaid, idtelefono, gmailid, idlocalidad, nombre, fechadenacimiento,tipodocumento, numdocumento,altura, calle, telefono, gmail );
        }
    }
}
