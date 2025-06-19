using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class Math
    {
        public static int Exponent(int num)
        {
            int result = num * num;
            return result;
        }

        public static int Sum(int num)
        {
            int result = num + 100;
            return result;
        }

        public static int Diff(int num)
        {
            int result = 100 - num;
            return result;
        }
    }
}
