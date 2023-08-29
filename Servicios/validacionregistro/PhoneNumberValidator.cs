using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;

namespace servicios
{
    public class PhoneNumberValidator
    {
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Expresión regular para validar el formato del número de teléfono
            string pattern = @"^\d{10}$";

            // Comprobación de la cadena de texto con la expresión regular
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }
    }
}
