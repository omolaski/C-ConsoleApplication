using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIFConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started from the bottom now we are here");
            Console.WriteLine("This program is working great");

            Employee employee = new Employee();

            employee.name = "Taiwo Emmanuel Omolaja";

            Console.WriteLine(employee.name);

        }
        public class Employee
        {
            public string name { get; set; }

        }
    }
}
