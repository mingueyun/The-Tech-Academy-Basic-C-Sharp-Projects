using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesObjects
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Speed s = new Speed();
            Program sp = new Program();


            int twoSpeeds;
            
            Console.WriteLine("whats your current speed? ");
            int currentSpeed = Convert.ToInt32(Console.ReadLine());
            twoSpeeds = sp.MySpeed(currentSpeed, s.postedSpeed);
            Console.WriteLine("you are going " + currentSpeed + " and the posted speed is " + s.postedSpeed);

            double gasMileage;
            Console.WriteLine("\nHow much miles did you drive? ");
            double milesDriven = Convert.ToDouble(Console.ReadLine());
            gasMileage = sp.Gas(milesDriven, s.startedMiles);
            Console.WriteLine(" you have used " + gasMileage + " gallon of gas cause you have driven " +  milesDriven + " miles since you started at " + s.startedMiles + " miles.");


            Console.ReadLine();
      
        }
        public int MySpeed(int speed1, int speed2)
        {
            int fast;
            if (speed1 > speed2)
                fast = speed1;
            else
                fast = speed2;
            return fast;

        }

        public double Gas ( double gas1, double gas2)
        {
            double burning;
            if (gas1 > 0)
                burning = gas1  / 30;
            else
                burning = gas1;
            return burning;
        }

    }
}
