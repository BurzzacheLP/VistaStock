﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace capaServicios
{
    internal class ValidarMail
    {
        /* Metodo que valida el formato de los mails escribiendo en color rojo 
           mientras no se cumpla el formato correcto, cambiando a negro al momento 
           de cumplirse dicho formato. 
           Se llama al metodo desde la propiedad TextChanged del textBox correspondiente
           de la siguiente manera:
        */
        public static bool Valid(string Correo)
        {
            String validacion;
            validacion = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            //validacion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Correo, validacion))
            {
                if (Regex.Replace(Correo, validacion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
