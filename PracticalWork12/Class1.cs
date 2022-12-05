using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork12
{
    internal class Class1
    {
        public static int SegmentLengthMultiplication(int point1, int point2, int point3)
        {
            int ac, bc;

            ac = Math.Abs(point3 - point1);
            bc = Math.Abs(point2 - point3);

            return ac * bc;
        }

        public static void DigitSumMult(int num, out int sum, out int mult)
        {
            int one = num / 100, two = num % 100 / 10, three = num % 10;
            sum = one + two + three;
            mult = one * two * three;
        }
    }
}
