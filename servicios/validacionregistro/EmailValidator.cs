﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace servicios
{
    public class EmailValidator
    {
        public bool IsValidEmail(string email)
        {
            // Expresión regular para validar el formato del correo electrónico
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Comprobación de la cadena de texto con la expresión regular
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }

}

