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
            int stuff = SelectString;
            int pos = Array.IndexOf(StringArray, stuff);

            Console.WriteLine("The array contains the following values:");
            for (int i = StringArray.GetLowerBound(0); i <= StringArray.GetUpperBound(0); i++)
                Console.WriteLine("   [{0,2}]: {1}", i, StringArray[i]);



            if (pos <= -1)

                Console.WriteLine("you selected the month of " + StringArray[SelectString]);

            else
            {
                Console.WriteLine("wrong selection choose another month");
            }


            //int[] numArray = { 5, 10, 200, 100, 500, 1, 300, 600, 1000, 2, 555 };
            //Console.WriteLine("please select from 0 - 10 for your lucky number ");
            //int selectNumber = Convert.ToInt32(Console.ReadLine());

            //int value = selectNumber;
            //int index = Array.IndexOf(numArray, value);



            //if (index >= -1)

            //    Console.WriteLine("Your lucky number is " + numArray[value]);

            //else
            //{
            //    Console.WriteLine("Wrong selection choose another number");

            //}



            //List<string> pick = new List<string>(3);
            //pick.Add("convertible");
            //pick.Add("wheels");
            //pick.Add("engine");


            //Console.WriteLine("pick a number to see what part you just won! 0-3");
            ////int one = convert.toint32(console.readline());
            ////console.writeline(pick.indexof(one.tostring("")));

            //string one = Console.ReadLine();
            //Console.WriteLine("");

            Console.ReadLine();
        }

    }
}
