using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string animals = "zebras";
            //concat more animals to string
            animals = animals + ", horses";
            animals = animals + ", otters";
            Console.WriteLine(animals);

            string name = "Joshy";
            // uppercase name
            name = name.ToUpper();
            Console.WriteLine(name);

            //CreateInstanceBinder stringbuilder object and add animals to it as animals string
            StringBuilder sb = new StringBuilder();
            sb = sb.Append(animals + ", flies");
            Console.WriteLine(sb.ToString());
        }
    }
}
