using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class extensionDouble
    {

        public static double getFractionPart(this double value)
        {  
            return value%1;
        }

    }
}
