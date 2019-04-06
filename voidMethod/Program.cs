using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
    class Program
    {
        
        //SeatBucket obj = new SeatBucket();
         static void Main(string[] args)
        {

            //SeatBucket pr = new SeatBucket();
            //var seats = new SeatBucket();
            //seats.Add();

            int pos1, pos2, pos3;
            Add(out pos1, out pos2, out pos3);


            Console.WriteLine("sum of the two " + pos1 + " / " + pos2 + " / " + pos3);
            Console.ReadLine();

        }
        public static void Add(out int a, out int b, out int c)
        {

            a = 3;
            b = 2;
            c = a + b;


        }


    }
}

