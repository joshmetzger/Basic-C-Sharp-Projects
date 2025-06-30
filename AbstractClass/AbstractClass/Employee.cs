using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittable
    {
        // method that can overrides it's parent method
        public override void SayName()
        {
            Console.WriteLine("Employess: ");
            base.SayName();
        }

        // inheritted from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee has quit... ");
        }
    }
}
