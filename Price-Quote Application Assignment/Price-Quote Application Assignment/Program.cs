using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express");
            Console.ReadLine();

            Console.WriteLine("What is your package weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            string result = packageWeight >= 50 ? "Package to heavy to be shipped via Pachage express. Have a good day." : "package accepted";
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("What is your package width?");
            int packageWidth = Console.ReadLine();
            int packwidth = Convert.ToInt32(packageWidth);
            Console.WriteLine("Your package width is: " + packageWidth);
            Console.ReadLine();

            Console.WriteLine("What is your package height?");
            int packageHeight = Console.ReadLine();
            Console.WriteLine("Your package weight is: " + packageHeight);
            Console.ReadLine();

            Console.WriteLine("What is your package lenght?");
            int packageLenght = Console.ReadLine();
            Console.WriteLine("Your package weight is: " + packageLenght);
            Console.ReadLine();

            Console.WriteLine("What is total Dimension?");
            int totalDimension = Convert.ToInt32(Console.ReadLine());
            string total = totalDimension >= 50 ? "Package too big to be shipped via Package Express. Have a good day." : " Package Accepted";
            Console.WriteLine(total);
            Console.ReadLine();

            int totalPrice = (packageWidth * packageHeight * packageLenght) % 100;

            Console.WriteLine(totalPrice);
            Console.ReadLine();

        }
    }
}
