using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Employee information obtained by properties and methods:\n");
            Console.WriteLine($"First name is{employee.FirstName}");
            Console.WriteLine($"Last name is{employee.LastName}");
            Console.WriteLine($"Social security number is{employee.SocialSecurityNumber}");
            Console.WriteLine($"Gross sales are{employee.GrossSales:C}");
            Console.WriteLine($"Commission rate is{employee.CommissionRate:F2}");
            Console.WriteLine($"Earnings are{employee.Earnings():C}");
            Console.WriteLine($"Base salary is {employee.Basesalary:C}");
            employee.Basesalary = 1000.00M;

            Console.WriteLine("\nUpdated employee information obtained by ToString:\n");
            Console.WriteLine(employee);
            Console.WriteLine($"earnings:{employee.Earnings():C}");
            Console.ReadLine();
        }
    }
}
