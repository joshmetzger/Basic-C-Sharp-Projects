using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new employee object
            Employee employee1 = new Employee();
            // set name properties of new object
            employee1.firstName = "Sample";
            employee1.lastName = "Student";

            // call the method on the object
            employee1.SayName();

        }
    }
}
