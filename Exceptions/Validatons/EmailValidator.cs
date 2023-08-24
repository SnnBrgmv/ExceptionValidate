using Exceptions.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Validatons
{
    public class EmailValidator
    {
        public bool Validate(string mail) 
        {
            if(mail.Length < 10)
            {
                throw new ShortEmailException("Email must be at least 10 characters length");
            }

            if (!mail.EndsWith("@mail.com"))
            {
                throw new NotAnEmailAdressException("Email must end with @mail.com");
            }
            return true;
        }
    }
}
