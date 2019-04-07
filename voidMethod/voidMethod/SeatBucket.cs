using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
      class SeatBucket
    {
    
        
        public int Add( int a,  int b)
        {
            int adding;

            if (a == b)
            {
                adding = a + b;
                Console.WriteLine("sum of the two " + adding);
            }
            else
            {
                adding = a % b;
                Console.WriteLine("remaining " + adding);

            }
            return adding;





        }

    }
}
