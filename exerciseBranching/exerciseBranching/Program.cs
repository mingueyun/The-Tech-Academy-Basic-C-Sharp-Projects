using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            double dimensions = width + height + length;

            double sumTotal = dimensions * weight / 100;
            decimal quote = Convert.ToDecimal(sumTotal);

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: {0:c}\nThanks", quote);
            }

            Console.ReadLine();
        }
    }
}
