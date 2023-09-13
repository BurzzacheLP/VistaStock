using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
using comun;
using servicios;

namespace logica
{
    public static class ActualizarDatosu
    {
        public static bool intentar( bool bloqueado,string username, string password, string permiso, DateTime fechaFin)
        {
            if(fechaFin<=DateTime.Today)
            {
                if (Comun.FechaFin >= DateTime.Today)
                {
                    BorrarinfoPersonal.borrar(DatosUcache.UserID);
                  
                }
            }
            string passwordE = password;
            if (password!=DatosUcache.Contrasena)
            {
                passwordE = PasswordEncryptor.EncryptPassword(password);
                ActualizarPassword.actualizar(username,passwordE+PasswordEncryptor.EncryptPassword(username));

            }
       
            ActualizarDatosU actualizarDatosU = new ActualizarDatosU();
            if (actualizarDatosU.Ejecutar(bloqueado, DatosUcache.UserID, username, permiso, fechaFin))
            {
                return true;
            }
            else
            { 
                return false; 
            }


        }
    }
}
