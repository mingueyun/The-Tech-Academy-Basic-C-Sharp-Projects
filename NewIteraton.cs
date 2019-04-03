using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array, 
            //adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.

            //List<string> names = new List<string>() { "stack", "hack", "guy", "jesse" };

            //Console.WriteLine("what is the name of the person you seek revenge on? \n");
            //string revenge = Console.ReadLine();
            //names.Add(revenge);
            //foreach (string name in names)
            //{

            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();

            //2.Create an infinite loop.
            //List<int> myAges = new List<int>();

            //myAges.Add(12);
            //myAges.Add(7);
            //myAges.Add(55);
            //myAges.Add(33);
            //myAges.Add(70);

            //for (int a = 0; a < myAges.Count; a--)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();




            //3.Fix the infinite loop so it will execute.
            //List<int> myAges = new List<int>();
            //myAges.Add(12);
            //myAges.Add(7);
            //myAges.Add(55);
            //myAges.Add(33);
            //myAges.Add(56);

            //for (int a = 0; a < myAges.Count; a++)
            //{
            //    if (myAges[a] < 13)
            //        Console.WriteLine("The ages list are " + myAges[a]);
            //}
            //Console.ReadLine();


            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.   
            //List<int> myAges = new List<int>();
            //myAges.Add(12);
            //myAges.Add(7);
            //myAges.Add(55);
            //myAges.Add(33);
            //myAges.Add(56);

            //for (int a = 0; a < myAges.Count; a++)
            //{
            //    if (myAges[a] > 13)
            //        Console.WriteLine("The ages list are " + myAges[a]);
            //}
            //Console.ReadLine();


            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            //List<int> myAges = new List<int>();
            //myAges.Add(12);
            //myAges.Add(7);
            //myAges.Add(55);
            //myAges.Add(33);
            //myAges.Add(56);

            //for (int a = 0; a < myAges.Count; a++)
            //{
            //    if (myAges[a] >=50)
            //        Console.WriteLine("The ages list are " + myAges[a]);
            //}
            //Console.ReadLine();

            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.

            //List<string> carColors = new List<string>() { "red", "yellow", "blue", "green", "pink" };


            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //string myColors = Console.ReadLine();

            //Console.WriteLine("Index of  : {0}", carColors.IndexOf(myColors));

            //Console.ReadLine();



            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //List<string> carColors = new List<string>() { "red", "yellow", "blue", "green", "pink" };


            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //int myColors = Convert.ToInt32(Console.ReadLine());
            //if(myColors > -1 &&  myColors < 5)
            //{
            //    Console.WriteLine("Index of " + carColors[myColors]);
            //}
            //else
            //{
            //    Console.WriteLine(" you entered something wrong");
            //}

            //Console.ReadLine();



            ///  I also made one this way too
            ///  

            //List<string> carColors = new List<string>() { "red", "yellow", "blue", "green", "pink" };


            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //string myColors = Console.ReadLine();

            //if (carColors.Any(x => x == myColors))
            //{
            //    Console.WriteLine("Index of  : {0}", carColors.IndexOf(myColors));
            //}
            //else
            //{
            //    Console.WriteLine(" you entered something wrong");
            //}


            //Console.ReadLine();

            ///

            //8.Add code to that above loop that stops it from executing once a match has been found.


            //List<string> carColors = new List<string>() { "red", "yellow" };


            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //string myColors = Console.ReadLine();

            //switch (myColors)
            //{
            //    case "red":
            //        Console.WriteLine("Index value is {0}", "1");
            //        break;
            //    case "yellow":
            //        Console.WriteLine("Index value is {0}", "2");
            //        break;
            //    default:
            //        Console.WriteLine("try again");
            //        break;


            //}


            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.


            //string[] arr = { "red", "yellow", "blue", "green", "pink", "red" };
            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //string myColors = Console.ReadLine();


            //int index = -1;
            //do
            //{
            //    index = Array.IndexOf(arr, myColors, index + 1);
            //    System.Console.WriteLine("The matching string are in index: " + index);
            //} while (0 == index);



            //Console.ReadLine();






            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //string[] arr = { "red", "yellow", "blue", "green", "pink", "red" };
            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //string myColors = Console.ReadLine();


            //int index = -1;
            //do
            //{


            //    if (arr.Any(x => x == myColors))
            //    {
            //        index = Array.IndexOf(arr, myColors, index + 1);
            //        System.Console.WriteLine("The matching string are in index: " + index);
            //    }
            //    else
            //    {
            //        Console.WriteLine(" you entered something wrong");
            //    }
            //} while (0 == index);



            //Console.ReadLine();







            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list,
            //and displays a message showing the string and whether or not it has already appeared in the list.

            string [] carColors = { "red", "yellow", "blue", "green", "pink", "blue"};
            string aColor = "blue";
           
         
            foreach (string color in carColors)
            {
                if (color.Contains(aColor))
                {
                    Console.WriteLine("Yes its in here :  " + aColor.ToUpper());
                }
                else
                    Console.WriteLine("Not this Color : " + color);
                

            } 
            
 
           
            Console.ReadLine();
        }
    }
}
