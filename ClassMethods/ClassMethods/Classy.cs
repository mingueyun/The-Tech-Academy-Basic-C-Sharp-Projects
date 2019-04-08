using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Classy
    {
        public void ClassyNew(out int num1)
        {
            Console.WriteLine("Enter a number ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + " divided by 2 is " + num1 / 2);
        }      

    }
    public  class Classy2 
    {
        public int   ClassyNew2(int A, int B)
        {
            return A / B;

        }
        public float ClassyNew2(float A, float B)
        {
            return A - B;
        }


    }
       



        
}
