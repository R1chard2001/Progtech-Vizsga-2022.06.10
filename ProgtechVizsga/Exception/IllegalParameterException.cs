using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgtechVizsga
{
    public class IllegalParameterException : Exception
    {
        public IllegalParameterException(string message) : base(message)
        { }
        public IllegalParameterException() : base()
        { }
    }
}
