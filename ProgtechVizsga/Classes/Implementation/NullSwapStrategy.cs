using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgtechVizsga
{
    public class NullSwapStrategy : ASwapStrategy
    {
        public NullSwapStrategy(char inputChar, char swapChar, int frequency) : base(inputChar, swapChar, frequency)
        {

        }

        public override char GetSwappedChar(char inputChar)
        {
            return inputChar;
        }
    }
}
