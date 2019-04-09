using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassExercise
{
    public class Employee : Person
    {
        public int ID { get; set; }
        public void Fired()
        {
            //throw new NotImplementedException();
        }
    }  
}
