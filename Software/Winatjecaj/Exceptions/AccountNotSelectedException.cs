using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winatjecaj.Exceptions
{
    // Autor: nrisek
    public class AccountNotSelectedException : ApplicationException
    {
        public string message;

        public AccountNotSelectedException(string _message)
        {
            message = _message;
        }
    }
}
