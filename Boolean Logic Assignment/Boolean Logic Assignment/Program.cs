using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            Console.WriteLine("Your age is:" + yourAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever have a DUI?");
            string yourDUI = Console.ReadLine();
            Console.WriteLine("Number of DUI:" + yourDUI);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            Console.WriteLine("Number of tickets:" + yourTickets);
            Console.ReadLine();

            Console.WriteLine("Qualified?");
        }
    }
}
