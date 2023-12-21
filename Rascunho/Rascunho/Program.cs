using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            double tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee = new Employee { Name = name, BaseSalay = salary, Tax = tax };
            Console.WriteLine("Employee: " + employee);

            Console.Write("Enter the percentage to increase the salary: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            employee.IncreaseSalary(percentage);

            Console.Write("Updated dada: " + employee);

            Console.ReadKey();
        }
    }
}
