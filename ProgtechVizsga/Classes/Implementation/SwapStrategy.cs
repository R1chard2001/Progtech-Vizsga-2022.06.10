using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgtechVizsga
{
    class SwapStrategy : ASwapStrategy
    {
        public SwapStrategy(char inputChar, char swapChar, int frequency) : base(inputChar, swapChar, frequency)
        {

        }

        public override char GetSwappedChar(char inputChar)
        {
            if (inputChar == this.InputChar)
            {
                this.CurrentNumberFound++;
            }
            if (this.CurrentNumberFound == Frequency)
            {
                CurrentNumberFound = 0;
                return this.SwapChar;
            }
            return inputChar;
        }
    }
}
