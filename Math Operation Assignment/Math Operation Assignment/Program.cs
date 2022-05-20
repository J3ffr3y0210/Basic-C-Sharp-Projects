using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 50 * 50;
            Console.WriteLine("Fifty times Fifty=" + product.ToString());
            Console.ReadLine();
            
            int total = 5 + 25;
            Console.WriteLine("Five plus Twenty Five =" + total.ToString());
            Console.ReadLine();

            double qoutient = 125.0 / 12.5;
            Console.WriteLine("One hundred twenty five divide by twelve point five=" + qoutient.ToString());
            Console.ReadLine();

            bool trueOrFalse = 60 > 50;
            Console.Write("Is Sixty greater than Fifty:" + trueOrFalse.ToString());
            Console.ReadLine();

            int remainder = 50 % 7;
            Console.Write("The raminder of Fifty divide by 7 is:" + remainder.ToString());
            Console.ReadLine();

        }
    }
}
