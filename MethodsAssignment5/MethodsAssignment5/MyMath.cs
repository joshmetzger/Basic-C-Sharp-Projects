using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment5
{
    public class MyMath
    {
        // method to output an integer that is divided by 2
        public void DivideByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine("int Divided by 2: " + result);
        }

        // method with output parameters (result)
        public void MultiplyByTwo(int input, out int result)
        {
            result = input * 2;
        }
        
        // method overload to account for differnt input types.
        public void DivideByTwo(double num)
        {
            double result = num / 2;
            Console.WriteLine("double Divided by 2: " + result);
        }
    }
}
