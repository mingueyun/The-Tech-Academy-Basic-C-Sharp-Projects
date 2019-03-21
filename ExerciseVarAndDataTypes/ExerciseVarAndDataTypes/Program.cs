using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseVarAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Tech Academy\nStudent Daily Report\nWhat course are you on?");

            string course = Console.ReadLine();

            Console.WriteLine("what page number?");
            String page = Console.ReadLine();
            int pageNumber = Convert.ToInt32(page);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string answer = Console.ReadLine();
            bool asking = Convert.ToBoolean(answer);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            String gripe = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            String study = Console.ReadLine();
            int studyTime = Convert.ToInt32(study);

            Console.WriteLine("You have stated that you are on " + course + " , on page number " + pageNumber +
            " ,do you need help " + asking + ".\nthis is your feedback " + gripe + ".\n" + feedBack + ".\nTHis is how" +
            " many hours you studied " + studyTime + ".\n\nThank you for your answers. An Instructor will respond to this shortly. Have a great day! ");
            Console.ReadLine();



        }
    }
}
