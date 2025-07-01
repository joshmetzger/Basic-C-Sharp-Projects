using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }
        public List<T> things { get; set; } = new List<T>();

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
        //public static bool operator ==(Employee a, Employee b)
        //{
        //    return a.Id == b.Id;
        //}

        //need the opposite: overload != operator to compare Id
        //public static bool operator !=(Employee a, Employee b)
        //{
        //    return !(a.Id == b.Id);
        //}

    }
}
