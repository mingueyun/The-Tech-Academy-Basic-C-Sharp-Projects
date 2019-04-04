using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numArray3 = { 10, 2, 10, 200, 5000 };
               
                Console.WriteLine("pick a number");
                int numb = Convert.ToInt32(Console.ReadLine());
                foreach (var d in numArray3)
                {
                    var result = d / numb;
                    Console.WriteLine("divide by " + numb + "  is " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

             
            //}
            // exception message that popped up
            //added whole numbers and it gave me whole numbers
            // added decimals and it gave me input was wrong format
            // added zero and it gave me wrong format
            //added string gave me wrong format

            // with try catch expections
            // 0 gave me tried to divide by zero
            // decimal gave me wronge string format
            // string input said wrong string format

        }
    }
}
