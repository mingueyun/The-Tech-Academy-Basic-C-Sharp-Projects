using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _137StructEx
{
    class Program
    {
        static void Main()
        {
          
            Number number = new Number("Min" , 50.0m);
            Console.WriteLine(" person1 name is = {0} and debt  Amount = {1} ", number.Name, number.Amount);

            Console.ReadLine();

        }
    }
}
