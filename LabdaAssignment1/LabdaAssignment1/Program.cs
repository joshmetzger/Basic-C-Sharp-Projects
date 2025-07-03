using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabdaAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create employee list
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, firstName = "Joe", lastName = "Smith"},
                new Employee { Id = 2, firstName = "Joe", lastName = "Johnny"},
                new Employee { Id = 3, firstName = "Steve", lastName = "Smith"},
                new Employee { Id = 4, firstName = "Michael", lastName = "Stone"},
                new Employee { Id = 5, firstName = "Jeff", lastName = "Buckley"},
                new Employee { Id = 6, firstName = "Matt", lastName = "Reason"},
                new Employee { Id = 7, firstName = "Paul", lastName = "McCartney"},
                new Employee { Id = 8, firstName = "John", lastName = "Lennon"},
                new Employee { Id = 9, firstName = "Ringo", lastName = "Splorwok"},
                new Employee { Id = 10, firstName = "Tommy", lastName = "Drummer"},
            };

            // instantiate employee list for Joe names
            List<Employee> Joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    // add to Joes list if match is found:
                    Joes.Add(employee);
                }
            }

            // instead add Joe matches to Joes list with lambda:
            List<Employee> joeEmployees = employees.Where(x => x.firstName == "Joe").ToList();

            //print results
            foreach (Employee employee in joeEmployees)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }

            //lambda for employees with Id > 5:
            List<Employee> employees5 = employees.Where(x => x.Id > 5).ToList();
            //print results
            foreach (Employee employee in employees5)
            {
                Console.WriteLine(employee.Id + " " + employee.firstName + " " + employee.lastName);
            }
        }
    }
}
