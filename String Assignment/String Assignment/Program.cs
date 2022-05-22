using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jeff";
            string qoute = "The man said, \"Hello\", Jeff.";
            string fileName = @"C:\Users\Jeff";
            Console.WriteLine(fileName);
            Console.ReadLine();

            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jeff, I am student of Academy of Learning.");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
