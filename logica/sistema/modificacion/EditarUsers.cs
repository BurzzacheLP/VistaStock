using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.procedimientos_almacenados;

namespace logica.sistema.modificacion
{
    public class EditarUsers
    {
        public bool editar(int userid, bool bloqueado, string username, string permiso, DateTime fechafin)
        {
            editarUsers editarusers = new editarUsers();
            return editarusers.EjecutarYDevolver(userid, bloqueado, username, permiso, fechafin );
        }
    }
}
