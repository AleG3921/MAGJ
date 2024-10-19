
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGJ.Temperatura
{
    internal class StringManipulator
    {
        public string ReversasString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        public string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
