using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethodsExercises
{
    public class MathStuff
    {
 

        public int ValueType(int first, int second)
        {

            int point1;
            if (first > second)
            {
                point1 = first * 10;
                Console.WriteLine("its greater " + point1);

            }
            else
            {
                point1 = first + 10;
                Console.WriteLine("its less " + point1);
            }
            return point1;


        }
        public double Value(double ssf, double stf)
        {

            double point2;
            if (ssf < stf)
            {
                point2 = ssf + 10;
                Console.WriteLine("its less " + point2);

            }
            else
            {
                point2 = ssf - 1;
                Console.WriteLine("its greater \n" + point2);
            }
            return point2;
            

        }
        public int Joust(int math1, int math2)
        {
            int baker;
            {


                baker = math1 + math2;
                Console.WriteLine("\nit  works : " + baker);

            }
            return baker;




            

        }
    }
}
