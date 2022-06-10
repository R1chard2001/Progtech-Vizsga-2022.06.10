using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgtechVizsga
{
    public abstract class ASwapStrategy
    {
        protected char InputChar;
        protected char SwapChar;
        protected int Frequency;
        protected int CurrentNumberFound;
        protected ASwapStrategy(char inputChar, char swapChar, int frequency)
        {
            this.InputChar = inputChar;
            this.SwapChar = swapChar;
            this.Frequency = frequency;
        }
        public abstract char GetSwappedChar(char inputChar);
    }
}
