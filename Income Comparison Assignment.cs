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
            string yourHourlyRate = Console.ReadLine();
            Console.WriteLine("Your Hourly Rate is:" + yourHourlyRate);
            Console.ReadLine();

            Console.WriteLine("How many Hours worked per week?");
            string yourHouraWorked = Console.ReadLine();
            Console.WriteLine("Your Hours worked per week is:" + yourHouraWorked);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("What is your Hourly rate?");
            string yourHourlyRate2 = Console.ReadLine();
            Console.WriteLine("Your Hourly Rate is:" + yourHourlyRate2);
            Console.ReadLine();

            Console.WriteLine("How many Hours worked per week?");
            string yourHouraWorked2 = Console.ReadLine();
            Console.WriteLine("Your Hours worked per week is:" + yourHouraWorked2);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1");
            string annualSalaryPerson1 = Console.ReadLine();
            Console.WriteLine("Anual salary of Person 1 is:" + annualSalaryPerson1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            string annualSalaryPerson2 = Console.ReadLine();
            Console.WriteLine("Anual salary of Person 2 is:" + annualSalaryPerson2);
            Console.ReadLine();

            int Person1 = 55000;
            int Person2 = 50000;
            bool trueorFalse = Person1 > Person2;
            Console.Write(trueorFalse.ToString());
            Console.ReadLine();
            
            Console.WriteLine("Does Person1 makes more money than Person2?");
            Console.ReadLine();
            


        }
    }
}
