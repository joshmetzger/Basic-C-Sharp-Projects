using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment2
{
    public class MyMath
    {
        //public static int Double(int num)
        //{
        //    int result = num + num;
        //    return result;
        //}

        //public static decimal Double(decimal num)
        //{
        //    decimal result = num + num;
        //    return result;
        //}

        public static int Double(string num)
        {
            int number = Convert.ToInt32(num);
            int result = number + number;
            return result;
        }
    }
}
