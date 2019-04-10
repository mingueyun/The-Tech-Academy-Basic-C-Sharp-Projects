using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee();
            Employee two = new Employee();
            one.id = 1;
            one.firstName = "sam";
            two.id = 2;
            two.firstName = "sam";
            Console.WriteLine(one.Equals(two));


            //Employee person = new Employee();

            //person.age = 6;
            //person.tellAge();



            //person.firstName = "Sample";
            //person.lastName = "student";
            //person.SayName();
            Console.ReadLine();



        }
    }
}
