﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGJ.Temperatura
{
    public class StringManipulator
    {
        public string ReversaString(string input)
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
