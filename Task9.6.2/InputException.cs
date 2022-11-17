using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    public class InputException : Exception
    {
        public InputException()
        {
        }
        public InputException(string message) : base(message)
        {
        }
    }
}
