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
            employee1.Id = 1;

            // create new employee object
            Employee employee2 = new Employee();
            // set name properties of new object
            employee2.firstName = "Josh";
            employee2.lastName = "Metzger";
            employee2.Id = 2;

            // try overloaded operator on the two employees
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);

            // call the method on the object
            employee1.SayName();

            // create IQuittable object, call the Quit method from the interface.
            IQuittable quittable = new Employee();
            quittable.Quit();


        }
    }
}
