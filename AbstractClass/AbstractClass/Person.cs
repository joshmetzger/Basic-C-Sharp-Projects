using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //method that can be overwritten by an inheritted class
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + this.firstName + " " + this.lastName);
        }

    }
}
