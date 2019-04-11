using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _137StructEx
{
     public struct Number
    {
        public decimal Amount { get; set; }
        public  string Name { get; set; }
        public Number( string name, decimal amount)
        {
            Name = name;
            Amount = amount;
            
        }
        

    }
}
