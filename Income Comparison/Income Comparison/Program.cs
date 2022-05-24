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
            int yourRate = Convert.ToInt32(yourHourlyRate);
            Console.WriteLine("Your Hourly Rate is:" + yourHourlyRate);
            Console.ReadLine();

            Console.WriteLine("How many Hours worked per week?");
            string yourHoursWorked = Console.ReadLine();
            int yourWorked = Convert.ToInt32(yourHoursWorked);
            Console.WriteLine("Your Hours worked per week is:" + yourHoursWorked);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("What is your Hourly rate?");
            string yourHourlyRate2 = Console.ReadLine();
            int yourRate2 = Convert.ToInt32(yourHourlyRate2);
            Console.WriteLine("Your Hourly Rate is:" + yourHourlyRate2);
            Console.ReadLine();

            Console.WriteLine("How many Hours worked per week?");
            string yourHoursWorked2 = Console.ReadLine();
            int yourWorked2 = Convert.ToInt32(yourHoursWorked2);
            Console.WriteLine("Your Hours worked per week is:" + yourHoursWorked2);
            Console.ReadLine();

            var salaryPerson1 = yourRate * yourWorked;
            int salary1 = salaryPerson1 * 52;
            
            Console.WriteLine("Annual Salary of Person 1");
            string annualSalaryPerson1 = Console.ReadLine();
            int annualPerson1 = Convert.ToInt32(annualSalaryPerson1);
            Console.WriteLine("Anual salary of Person 1 is:" + annualSalaryPerson1);
            Console.ReadLine();

            var salaryPerson2 = yourRate2 * yourWorked2;
            int salary2 = salaryPerson2 * 52;
            
            Console.WriteLine("Annual Salary of Person 2");
            string annualSalaryPerson2 = Console.ReadLine();
            int annualPerson2 = Convert.ToInt32(annualSalaryPerson2);
            Console.WriteLine("Anual salary of Person 2 is:" + annualSalaryPerson2);
            Console.ReadLine();

            bool trueorFalse = salary1 > salary2;
            Console.WriteLine(trueorFalse);
            Console.ReadLine();

        }
    }
}
