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
            seat = Grab(seat);
           
            

          


            
            Console.ReadLine();


        }
        public static  SeatBucket Grab(SeatBucket seat)
        {
            int score;
            Console.WriteLine("Enter your  available seats\n ");
            int firstMathScore = Convert.ToInt32(Console.ReadLine());
            score = seat.Add(firstMathScore, 12);
            return seat;

     
        }

    }

    
}


