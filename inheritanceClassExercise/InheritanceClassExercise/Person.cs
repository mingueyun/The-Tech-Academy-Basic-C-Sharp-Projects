﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassExercise
{
   public  class Person
    {

        
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void  SayName()
        {
            
            
            {
                string fullname = FirstName +  " " + LastName;
                Console.WriteLine("Name : "+ fullname);
            }
          
        }
    

    }
}
