using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilitiesExample
{
    public static class MathUtilities
    {
        public static double Pi = 3.14159;

        public static double CalculateCircleArea(double radius)
        {
            return Pi * radius * radius;
        }

        public static double CalculateSquareRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }

}
