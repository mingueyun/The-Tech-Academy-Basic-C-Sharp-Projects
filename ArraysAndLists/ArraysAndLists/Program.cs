using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] StringArray = { "jan", "feb", "mar", "apr", "may", "june", "jul", "aug", "sep", "oct", "nov", "dec" };
            Console.WriteLine("please select what month you were born in. 0 being jan - 11 being dec");
            int SelectString = Convert.ToInt32(Console.ReadLine());

            if (SelectString > -1 && SelectString < 12)
            {
                Console.WriteLine("The array contains the following values:");
                for (int i = StringArray.GetLowerBound(0); i <= StringArray.GetUpperBound(0); i++)
                    Console.WriteLine("   [{0,2}]: {1}", i, StringArray[i]);
                Console.WriteLine("you selected the month of " + StringArray[SelectString]);
            }
            else
            {
                Console.WriteLine("wrong selection choose another month");
            }




            int[] numArray = { 5, 10, 200, 100, 500, 1, 300, 600, 1000, 2, 555 };
            Console.WriteLine("please select from 0 - 10 for your lucky number ");
            int selectNumber = Convert.ToInt32(Console.ReadLine());

            if (selectNumber > -1 && selectNumber < 11)
            {
                Console.WriteLine("The array contains the following values:");
                for (int i = numArray.GetLowerBound(0); i <= numArray.GetUpperBound(0); i++)
                    Console.WriteLine("   [{0,2}]: {1}", i, numArray[i]);
                Console.WriteLine("Your lucky number is " + numArray[selectNumber]);
            }
            else
            {
                Console.WriteLine("Wrong selection choose another number");
            }





            List<string> pick = new List<string>(3);
            pick.Add("convertible");
            pick.Add("wheels");
            pick.Add("engine");






            Console.WriteLine(pick[1]);
        

            Console.ReadLine();
        }

    }
}
