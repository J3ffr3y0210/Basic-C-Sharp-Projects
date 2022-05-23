using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("What is your Hourly rate?");
            int yourHourlyRate = Console.ReadLine();
            Console.WriteLine("Your Hourly Rate is:" + yourHourlyRate);
            Console.ReadLine();

            Console.WriteLine("How many Hours worked per week?");
            int yourHouraWorked = Console.ReadLine();
            Console.WriteLine("Your Hours worked per week is:" + yourHouraWorked);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("What is your Hourly rate?");
            int yourHourlyRate2 = Console.ReadLine();
            Console.WriteLine("Your Hourly Rate is:" + yourHourlyRate2);
            Console.ReadLine();

            Console.WriteLine("How many Hours worked per week?");
            int yourHouraWorked2 = Console.ReadLine();
            Console.WriteLine("Your Hours worked per week is:" + yourHouraWorked2);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1");
            int annualSalaryPerson1 = Console.ReadLine();
            Console.WriteLine("Anual salary of Person 1 is:" + annualSalaryPerson1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            int annualSalaryPerson2 = Console.ReadLine();
            Console.WriteLine("Anual salary of Person 2 is:" + annualSalaryPerson2);
            Console.ReadLine();

            int Person1 = yourHourlyRate * yourHouraWorked * 52;
            int Person2 = yourHourlyRate2 * yourHouraWorked2 * 52;
            bool trueorFalse = Person1 > Person2;
            trueorFalse= ("Does Person1 makes more money than Person2?");
            Console.WriteLine(trueorFalse);
            Console.ReadLine();
          
        }
    }
}
