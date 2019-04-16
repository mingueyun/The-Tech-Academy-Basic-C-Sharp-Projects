using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _154logFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tell me a number");
            int answer = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Mingu\logs\number.txt", true))
            {
                file.WriteLine(answer);
            }
            using (StreamReader sr = new StreamReader(@"C:\Users\Mingu\logs\number.txt"))
            {
                string line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
            Console.ReadLine();
           
                
            
        }
        
        
    }
}
