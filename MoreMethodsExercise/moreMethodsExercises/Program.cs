using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethodsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MathStuff mathstuff = new MathStuff();
            mathstuff = DoStuff(mathstuff);



            
            


            Console.ReadLine();

        }
          public static MathStuff DoStuff(MathStuff mathstuff )
        {
            int score;
            Console.WriteLine("Enter your  1st math score\n ");
            int firstMathScore = Convert.ToInt32(Console.ReadLine());
            score = mathstuff.ValueType(firstMathScore, 12  );

            double scores;
            Console.WriteLine("\nEnter your  2nd math score\n ");
            double secondtMathScore = Convert.ToDouble(Console.ReadLine());
            scores = mathstuff.Value(secondtMathScore, 4);

            int stuff;
            string one = "5";
            string two = "10";
            int math1 = Int32.Parse(one);
            int math2 = Int32.Parse(two);
            stuff = mathstuff.Joust(math1, math2);




            return mathstuff;


        }
    }
}
