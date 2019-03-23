using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        
        static void Main(string[] args)
        {



            Console.WriteLine("enter amount of cans to return less then 10?");
            int canEnter = Convert.ToInt32(Console.ReadLine());
            bool totalCan = canEnter == 10;
            decimal price = Convert.ToDecimal(canEnter);
            decimal cost = price * .32m;
            while (true)
            {
                if (canEnter <= 10)
                {
                    
                    Console.WriteLine(" this is the most we can give " + cost );
                    break;

                }
                else
                {
                    Console.WriteLine("please add the right amount");
                    break;
                }
                
            }

            Console.ReadLine();


            //Console.WriteLine("what is your User first name?");
            //string enterName = Console.ReadLine();
            //bool userName = enterName == "James";
            ////Console.WriteLine("Welcome James! please enter Password");
            //do
            //{
            //    switch (enterName)
            //    {
            //        case "jhon":
            //            Console.WriteLine("Sorry jhon are not authorized try another name.");
            //            Console.WriteLine("what is your User first name?");
            //            enterName = Console.ReadLine();
            //            break;
            //        case "jack":
            //            Console.WriteLine("Sorry jack are not authorized try another name.");
            //            Console.WriteLine("what is your User first name?");
            //            enterName = Console.ReadLine();
            //            break;
            //        case "James":
            //            Console.WriteLine("Welcome James! please enter Password.");
            //            userName = true;
            //            break;
            //        case "james":
            //            Console.WriteLine("Sorry james with a lower case are not authorized try another name.");
            //            Console.WriteLine("what is your User first name?");
            //            enterName = Console.ReadLine();
            //            break;

            //        default:
            //            Console.WriteLine("Please enter a valid name.");
            //            Console.WriteLine("what is your User first name?");
            //            enterName = Console.ReadLine();
            //            break;


            //    }
            //}
            //while (!userName);
            //Console.ReadLine();
        }
    }
}
