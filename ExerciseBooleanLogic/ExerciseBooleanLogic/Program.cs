using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int newAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? answer 'false' or 'true' ");
            string dui = Console.ReadLine();
            bool stuff = dui == "true";
            
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int tickets = Convert.ToInt32(ticket);

            bool qualed = newAge >= 5 && stuff == false && tickets < 3 ? true: false;

            Console.WriteLine("Qualified?\n" + qualed);
            Console.ReadLine();
        }
    }
}
