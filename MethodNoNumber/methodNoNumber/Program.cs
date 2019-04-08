using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodNoNumber
{
    class Program
    {
        static void Main(string[] args)
        {// this block of code makes sure that no input doesnt throw an exception for 2nd input

            NoNumber someNumber = new NoNumber();
         
            
            Console.WriteLine("Enter a number 1 ");
            int oneNum = int.Parse(Console.ReadLine( ));

            int twoNum;
            Console.WriteLine("Enter a number 2. if you dont know a number just push enter");
            bool result = int.TryParse(Console.ReadLine(), out twoNum);
            if (result)
            {
                someNumber.NoIntOption(oneNum, twoNum);
            }
            else
            {
                someNumber.NoIntOption(oneNum, 0);
            }
          
     

            Console.ReadLine();
        }
    }
}
