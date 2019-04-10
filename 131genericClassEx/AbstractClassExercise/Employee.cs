using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    public class Employee<T> : Person, IQuittable
    {
        public int id { get; set; }
        public List<T> Things { get; set; }

        // implementing sayname() method from person class

        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            tellAge();

        }
        
    }
}
