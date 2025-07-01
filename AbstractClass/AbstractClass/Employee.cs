using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // first and last name are inheritted from Person currently..
        // public string firstName { get; set; }
        // public string lastName { get; set; }

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

        //overload == operator to compare Id
        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id == b.Id;
        }

        //need the opposite: overload != operator to compare Id
        public static bool operator !=(Employee a, Employee b)
        {
            return !(a.Id == b.Id);
        }

    }
}
