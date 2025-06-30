using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person
    {
        // method that can overrides it's parent method
        public override void SayName()
        {
            Console.WriteLine("Employess: ");
            base.SayName();
        }
    }
}
