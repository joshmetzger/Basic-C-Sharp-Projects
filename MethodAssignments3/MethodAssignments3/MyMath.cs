using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignments3
{
    public class MyMath
    {
        public static int Add(int num1, int num2 = 0)
        {
            int result = num1 + num2;
            return result;
        }
    }
}
