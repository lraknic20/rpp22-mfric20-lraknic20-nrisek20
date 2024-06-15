using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winatjecaj.Exceptions
{
    // Autor: nrisek
    public class DataValidationException : ApplicationException
    {
        public string message;

        public DataValidationException(string _message)
        {
            message = _message;
        }
    }
}
