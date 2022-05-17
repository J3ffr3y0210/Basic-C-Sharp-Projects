using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you in?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is:" + yourCourse);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string yourPage = Console.ReadLine();
            Console.WriteLine("Your Page is:" + yourPage);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”");
            string DoYouNeedHelp = Console.ReadLine();
            Console.WriteLine("Do you need help:" + DoYouNeedHelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            string yourPositiveExperience = Console.ReadLine();
            Console.WriteLine("Your Positive experience is:" + yourPositiveExperience);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string yourfeedback = Console.ReadLine();
            Console.WriteLine("Your feedback is:" + yourfeedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string yourStudyHours = Console.ReadLine();
            Console.WriteLine("Your study hour today is:" + yourStudyHours);
            Console.ReadLine();


        }
    }
}
