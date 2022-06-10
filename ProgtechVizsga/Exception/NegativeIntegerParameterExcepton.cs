using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgtechVizsga
{
    public class NegativeIntegerParameterExcepton : IllegalParameterException
    {
        public NegativeIntegerParameterExcepton(string message) : base(message)
        {}
        public NegativeIntegerParameterExcepton() : this("Non negative integer expected")
        {}
    }
}
