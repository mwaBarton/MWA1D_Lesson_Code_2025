using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L185___Exceptions_2
{
    internal class PizzaBurntException : Exception
    {

        public PizzaBurntException(string message) : base(message) { }
    }
}
