using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace datos
{
    public abstract class conn
    {
        private static string cadena = "Data Source=localhost;Initial Catalog=login;Integrated Security=True;";
        public SqlConnection crear()
        {
            return new SqlConnection(cadena);
        }
    }
}
