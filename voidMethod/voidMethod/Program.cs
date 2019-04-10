using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
    class Program
    {

        static void Main()
        {
            SeatBucket seat = new SeatBucket();
            Program program = new Program();
            seat.Alpha = 4;
            seat.bravo = 4;
            seat.Add();

            Console.ReadLine();

        }
    }
}



