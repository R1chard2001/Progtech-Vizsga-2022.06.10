using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgtechVizsga
{
    public class NullStringParameterException : IllegalParameterException
    {
        public NullStringParameterException(string message) : base(message)
        { }
        public NullStringParameterException() : this("Not null string parameter expected!")
        { }
    }
}
