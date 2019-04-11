using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134EnumEx
{
    class Program
    {

        static void Main(string[] args)
        {

            Weeks week = new Weeks();
            week.DaysOfTheWeek = new DaysOfTheWeek();

            Console.WriteLine("what day of the week is it? ");
            string GuessDay = Console.ReadLine();


            try
            {
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), GuessDay);
                switch (GuessDay)
                {
                    case "Monday":
                        Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                        break;
                    case "Tuesday":
                        Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                        break;
                    case "Wednesday":
                        Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                        break;
                    case "Thursday":
                        Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                        break;
                    case "Friday":
                        Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                        break;
                    case "Saturday":
                        Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                        break;
                    case "Sunday":
                        Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                        break;
                    default:
                        Console.WriteLine("Please enter an actual day of the week. ");
                        break;


                }
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week. \n ", ex);


                // testing it gives an exception it cant find the incorrectly spelled stuff
                //DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), GuessDay);
                //if (Enum.IsDefined(typeof(DaysOfTheWeek), days) | days.ToString().Contains(GuessDay))
                //{
                //    Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                //}
                //else
                //{
                //    Console.WriteLine("Please enter an actual day of the week. ");

                //}






                //this one keeps iterating and prints all 7 days and it prints values.
                //foreach (string cname in Enum.GetNames(typeof(DaysOfTheWeek)))
                //{

                //    try
                //    {
                //        DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), GuessDay);
                //        if (Enum.IsDefined(typeof(DaysOfTheWeek), days) | days.ToString().Contains(","))
                //            Console.WriteLine("{0} = {1:D} ", GuessDay, Enum.Parse(typeof(DaysOfTheWeek), days.ToString()));
                //        else
                //            Console.WriteLine("Please enter an actual day of the week. ");
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine(ex);
                //    }





                // practice but it prints out all 7  but print the value a left or right bool. it doesnt work

                //int vale = Convert.ToInt32(week.DaysOfTheWeek);
                //foreach (var cname in Enum.GetNames(typeof(DaysOfTheWeek))) ;
                //{
                //    try
                //    {

                //        DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), GuessDay);
                //        if (Enum.IsDefined(typeof(DaysOfTheWeek), days) || days.ToString().Contains(","))
                //            Console.WriteLine("Your selection '{0}' is {1}.", GuessDay, days.ToString());
                //        else
                //            Console.WriteLine("Please enter an actual day of the week. ");
                //    }


                //    catch (Exception ex)
                //    {
                //        Console.WriteLine(ex);
                //    }

                //}


                Console.ReadLine();
            }
            
        }
    }
}
