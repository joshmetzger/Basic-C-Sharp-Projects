using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjects1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object from the inheritted class and set it's properties
            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";

            // call the inheritted method from the object's parent class where the method lives
            employee1.SayName();
        }
    }
}
