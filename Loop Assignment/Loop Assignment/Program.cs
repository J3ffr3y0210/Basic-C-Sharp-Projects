using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 16;

            do
            {
                switch (number)
                {
                    case 42:
                        Console.WriteLine("You guessed 42. Try again.");
                        Console.WriteLine("Guessed a number? ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 19:
                        Console.WriteLine("You guessed 19. Try again.");
                        Console.WriteLine("Guessed a number? ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("You guessed 10. Try again.");
                        Console.WriteLine("Guessed a number? ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 16:
                        Console.WriteLine("You guessed the number 16. That is correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.Read();


            while (!isGuessed)
            {
                switch (number)
                {
                    case 42:
                        Console.WriteLine("You guessed 42. Try again.");
                        Console.WriteLine("Guessed a number? ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 19:
                        Console.WriteLine("You guessed 19. Try again.");
                        Console.WriteLine("Guessed a number? ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("You guessed 10. Try again.");
                        Console.WriteLine("Guessed a number? ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 16:
                        Console.WriteLine("You guessed the number 16. That is correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            
            Console.Read();



        }
    }
}



        

    



            