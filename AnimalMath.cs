using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aardvark
{
    public static partial class AnimalMath
    {
        public static double Factorial(double d)
        {
            if (d == 1 || d == 0)
            {
                return 1;
            }
            return d * Factorial(d - 1);
        }
    }
}
