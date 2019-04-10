using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
    class SeatBucket
    {

        public int Alpha { get; set; }
        public int bravo { get; set; }
        public void Add()
        {


            if (Alpha == bravo)
            {
                int what = Alpha + bravo;
                Console.WriteLine("sum of the two " + what);
            }
            else
            {
                int what = Alpha % bravo;
                Console.WriteLine("remaining " + what);
            }

        }
    }
}
