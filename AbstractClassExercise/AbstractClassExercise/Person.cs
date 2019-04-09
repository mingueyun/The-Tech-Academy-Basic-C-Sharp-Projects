using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
     public  abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set;  }
        public virtual  void SayName()
        {
            string fullname = firstName + " " + lastName;
            Console.WriteLine("Name : " + fullname);
        }
        public void tellAge( )
        {
            int yourAge = age;
            Console.WriteLine("your age is : " + yourAge);

        }
    }
}
