using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatntiate the MyMath object
            MyMath myMath = new MyMath();

            //call the myFunc method from the class
            myMath.myFunc(100, 25);
        }
    }
}
