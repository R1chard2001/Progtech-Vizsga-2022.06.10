using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgtechVizsga
{
    public class StringCharSwapper
    {
        private static StringCharSwapper _instance;
        private ASwapStrategy _swapStrategy;

        public static StringCharSwapper getInstance()
        {
            if (_instance == null)
            {
                _instance = new StringCharSwapper();
            }

            return _instance;
        }
        private StringCharSwapper() { }

        public string Swap(string inputString, char searchedChar, char swapChar, int frequency)
        {
            parameterTests(inputString, frequency);
            StringBuilder sb = new StringBuilder();
            ChooseSwapStrategy(searchedChar, swapChar, frequency);
            foreach (char character in inputString)
            {
                sb.Append(GetSwappedChar(character));
            }

            return sb.ToString();
        }

        private void ChooseSwapStrategy(char searchedChar, char swapChar, int frequency)
        {
            if (frequency > 0)
            {
                this._swapStrategy = new SwapStrategy(searchedChar, swapChar, frequency);
            }
            else
            {
                this._swapStrategy = new NullSwapStrategy(searchedChar, swapChar, frequency);
            }
        }

        private char GetSwappedChar(char input)
        {
            return _swapStrategy.GetSwappedChar(input);
        }

        private void parameterTests(string inputstring, int frequency)
        {
            if (inputstring == null)
            {
                throw new NullStringParameterException();
            }

            if (frequency < 0)
            {
                throw new NegativeIntegerParameterExcepton();
            }
        }


    }
}
