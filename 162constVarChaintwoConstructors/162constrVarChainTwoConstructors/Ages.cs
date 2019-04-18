using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162constrVarChainTwoConstructors
{
    public class Ages
    {


        static Ages()
        {
            const string myName = "Min";
            Console.WriteLine("Your first name is {0}", myName);

        }
        public Ages(int myAge, string mynames)
        {
            this.Age = myAge;
            this.Name = mynames;

        }
           

        public Ages(int Yearnow, int yearborn)
        {
            Age = Yearnow - yearborn;
        }
        public int Age { get; set; }
        public string Name { get; set; }
  

    }
}
