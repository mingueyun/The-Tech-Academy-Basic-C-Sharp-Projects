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
            Employee person = new Employee();
            
            person.age = 6;
            person.tellAge();



            person.firstName = "Sample";
            person.lastName = "student";
            person.SayName();
            Console.ReadLine();



        }
    }
}
