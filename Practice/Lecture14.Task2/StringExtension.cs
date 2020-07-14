using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lecture14.Task2
{
    public static class StringExtension
    {
        public static string  CutString ( this string str)
        {
            const int startsymbol = 0;
            const int numberofsymbols = 5;
            string newstr = str.Substring(startsymbol, numberofsymbols);
            const string threepoints = "...";
            string cutstring = String.Concat(newstr, threepoints);
            return cutstring;
        }
    }
}
