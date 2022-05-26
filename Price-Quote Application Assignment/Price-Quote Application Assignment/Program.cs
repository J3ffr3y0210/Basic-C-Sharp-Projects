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
            string packageWeight = Console.ReadLine();
            int packweight = Convert.ToInt32(packageWeight);
            string result = packweight >= 50 ? "Package to heavy to be shipped via Pachage express. Have a good day." : "package accepted";
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("What is your package width?");
            string packageWidth = Console.ReadLine();
            int packwidth = Convert.ToInt32(packageWidth);
            Console.WriteLine("Your package width is: " + packageWidth);
            Console.ReadLine();

            Console.WriteLine("What is your package height?");
            string packageHeight = Console.ReadLine();
            int packheight = Convert.ToInt32(packageHeight);
            Console.WriteLine("Your package weight is: " + packageHeight);
            Console.ReadLine();

            Console.WriteLine("What is your package lenght?");
            string packageLenght = Console.ReadLine();
            int packlenght = Convert.ToInt32(packageLenght);
            Console.WriteLine("Your package weight is: " + packageLenght);
            Console.ReadLine();

            int totalDimention = (packwidth * packheight * packlenght);

            Console.WriteLine("What is total Dimension?");
            string totalDimension = Console.ReadLine();
            int totdimension = Convert.ToInt32(totalDimension);
            string resultTotal = totdimension >= 50 ? "Package too big to be shipped via Package Express. Have a good day." : " Package Accepted";
            Console.WriteLine(resultTotal);
            Console.ReadLine();

            var DollarValue = totalDimension % 100;

            Console.WriteLine(DollarValue);
            Console.ReadLine();

        }
    }
}
