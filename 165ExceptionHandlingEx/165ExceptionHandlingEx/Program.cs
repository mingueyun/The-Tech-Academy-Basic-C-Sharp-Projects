using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _165ExceptionHandlingEx
{
    class Program
    {
        static void Main(string[] args)
        {

            bool correctAge = false;
            int HowOld = 0;
            try
            {
                while (!correctAge)
                {
                    Console.WriteLine("What is your age?\n");
                    correctAge = int.TryParse(Console.ReadLine(), out HowOld);
                    if (!correctAge) Console.WriteLine("thats not what i was asking");
                }
                if (HowOld >= 1)
                {
                    Console.WriteLine("you are {0} years old ", HowOld);
                    Console.WriteLine(DateTime.Now.AddYears(-HowOld).ToString("You were born in " + "yyyy"));
                    Console.ReadLine();
                    

                }
                else
                {
                    Console.WriteLine(" you have entered an incorrect age. please enter correctly.");
                    Console.ReadLine();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }

        }

    }
}

//bool correctAge = false;
//int HowOld = 0;
//            while (!correctAge)
//            {

//                try
//                {
//                    Console.WriteLine("What is your age?\n");
//                    correctAge = int.TryParse(Console.ReadLine(), out HowOld);
//                    if (!correctAge) Console.WriteLine("thats not what i was asking");
                 
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex);
//                    Console.ReadLine();
//                    return;
//                }

//                if (HowOld >= 1)
//                {
//                    Console.WriteLine("you are {0} years old ", HowOld);
//                    Console.WriteLine(DateTime.Now.AddYears(-HowOld).ToString("You were born in " + "yyyy"));
//                }
//                else if (HowOld <= 0)
//                {
//                    Console.WriteLine("You cant be seriouse right? ");
//                    Console.ReadLine();
//                    return;

//                }
//                Console.ReadLine();