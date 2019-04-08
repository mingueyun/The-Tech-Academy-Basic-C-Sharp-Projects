using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public static  class Program
    {
        static void Main(string[] args)
        {
            Classy ClueLess = new Classy();
            Classy2 NotVlueLess = new Classy2();
            int a;
            
            ClueLess.ClassyNew(out  a );

            Console.WriteLine("the value of input is {0}\n", a);
            Console.WriteLine(NotVlueLess.ClassyNew2(20, 2));
            Console.WriteLine(NotVlueLess.ClassyNew2(4.6f, 2.3f));

            Console.ReadLine();
        }
    }
}
