using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDebugging
{
    internal class CustomExceptionAge : Exception
    {
        public CustomExceptionAge(string message) : base(message)
        {
        }
    }
}
