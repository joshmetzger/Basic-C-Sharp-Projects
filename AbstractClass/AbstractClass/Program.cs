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
            //Employee employee1 = new Employee();
            //// set name properties of new object
            //employee1.firstName = "Sample";
            //employee1.lastName = "Student";
            //employee1.Id = 1;

            //// create new employee object
            //Employee employee2 = new Employee();
            //// set name properties of new object
            //employee2.firstName = "Josh";
            //employee2.lastName = "Metzger";
            //employee2.Id = 2;

            //// try overloaded operator on the two employees
            //Console.WriteLine(employee1 == employee2);
            //Console.WriteLine(employee1 != employee2);

            // call the method on the object
            //employee1.SayName();

            //// create IQuittable object, call the Quit method from the interface.
            //IQuittable quittable = new Employee();
            //quittable.Quit();

            // instantiate new employee object with string paramater for things
            Employee<string> employee1 = new Employee<string>();
            // set the things property to a list of strings
            employee1.things = new List<string>{ "broom", "mop", "computer"};

            // instantiate new employee object with int paramater for things
            Employee<int> employee2 = new Employee<int>();
            // set the things property to a list of integers
            employee2.things = new List<int> { 17, 32, 55555 };

            //print string things
            foreach (string thing in employee1.things)
            {
                Console.WriteLine(thing);
            }

            // print int things
            foreach (int thing in employee2.things)
            {
                Console.WriteLine(thing);
            }





        }
    }
}
