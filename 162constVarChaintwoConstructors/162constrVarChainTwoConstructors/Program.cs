using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162constrVarChainTwoConstructors
{
    class Program
    {

        static void Main(string[] args)
        {
            var ages = new Ages(2019, 1979);


            Console.WriteLine("you are {0} years old", ages.Age);

            Console.ReadLine(); 

        }
        
        
    }
}
