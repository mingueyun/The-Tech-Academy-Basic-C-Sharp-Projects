using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _156dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("give me number in hours you want to be reminded?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(x));


       

            Console.ReadLine();
        }

    }
}
