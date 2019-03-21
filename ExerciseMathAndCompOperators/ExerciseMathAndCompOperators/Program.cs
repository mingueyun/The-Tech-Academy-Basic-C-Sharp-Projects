using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMathAndCompOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n\nPerson 1");
            Console.WriteLine("Hourly rate?");
            string hour = Console.ReadLine();
            decimal pay = Convert.ToDecimal(hour);
            Console.WriteLine(pay.ToString("c"));
          


            Console.WriteLine("Hours worked per week?");
            string work = Console.ReadLine();
            decimal perWeek = Convert.ToDecimal(work);
            Console.WriteLine(+ perWeek + " Hours");



            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string hour2 = Console.ReadLine();
            decimal pay2 = Convert.ToDecimal(hour2);
            Console.WriteLine(pay2.ToString("c"));

            Console.WriteLine("Hours worked per week?");
            string work2 = Console.ReadLine();
            decimal perWeek2 = Convert.ToDecimal(work2);
            Console.WriteLine(+perWeek2 + " Hours");

            decimal money1 = pay * perWeek;
            decimal money2 = pay2 * perWeek2;

            Console.WriteLine("Weekly salary of Person 1:\n" + money1.ToString("c"));
            Console.WriteLine("Weekly salary of Person 2:\n" + money2.ToString("c"));

            bool payDifferance = money1 > money2;
            Console.WriteLine("Does Person 1 make more money then Person 2?\n" + payDifferance);
            Console.ReadLine();
        }
    }
}
