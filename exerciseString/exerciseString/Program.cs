using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your first name");
            string fName = Console.ReadLine();
            Console.WriteLine("what is your middle name");
            string mName = Console.ReadLine();
            Console.WriteLine("what is your last name");
            string lName = Console.ReadLine();

            string totalName = fName + mName + lName;
            totalName = totalName.ToUpper();

            Console.WriteLine("your first name is: " + fName + " middle name is: " + mName + " and last name is: " + lName);
         
            Console.WriteLine( totalName);

            StringBuilder sb = new StringBuilder("There are dogs barking outside?");
            sb.Append(" After 10 minuets they are quite now!");
            
            sb.Insert(32,".... waiting quietly for 10 minuets.");
            sb.Replace('?', '!');

            Console.WriteLine(sb);


            Console.ReadLine();


        }
    }
}
