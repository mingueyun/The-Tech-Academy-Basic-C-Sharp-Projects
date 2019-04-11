using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140LamdaEx
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            { 


            employees.Add(new Employee() { FirstName = "James", LastName = "Krack", Id = 1 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "schmoe", Id = 2 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Kracker", Id = 3 });
            employees.Add(new Employee() { FirstName = "Steam", LastName = "Roll", Id = 4 });
            employees.Add(new Employee() { FirstName = "Boiling", LastName = "Water", Id = 5 });
            employees.Add(new Employee() { FirstName = "Jack", LastName = "Off", Id = 6 });
            employees.Add(new Employee() { FirstName = "June", LastName = "Bug", Id = 7 });
            employees.Add(new Employee() { FirstName = "Jasper", LastName = "Cool", Id = 8 });
            employees.Add(new Employee() { FirstName = "Min", LastName = "TheGreat", Id = 9 });
            employees.Add(new Employee() { FirstName = "Suck", LastName = "You", Id = 10 });

             }


            List<Employee> newJJ = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (var employee in newJJ)
            {

                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Id}\n");

            }



            List<Employee> newjoelist = employees.Where(x => x.Id > 5).ToList();
            foreach (var employee in newjoelist)
            {

                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Id}");

            }







            //int ncount = 0;

            //List<Employee> newjlist = new List<Employee>();
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //    if (employee.FirstName == "Joe")
            //    {
            //        ncount++;
            //        newjlist.Add(employee);
            //    }
            //}
            //Console.WriteLine("\nthere are " + ncount + " Joes that matches\n");

            //foreach (Employee employee in newjlist)
            //{
            //    
            //    Console.WriteLine("employees : {0}", employee);

            //}


            ////didnt like this one cause i wanted to print out all the employees using overide string() but this one has a weird loop so the second one seperates the everything they way i want but the
            //// second code block is a bit lengthier using 2 foreach
            //int ncount = 0;
            //// starts goig through the list starting from 0 and then looks for joe
            //List<Employee> newjoelist = new List<Employee>();
            //foreach (var employee in employees)
            //{

            //    if (employee.FirstName == "Joe")
            //    {
            //        ncount++;
            //        newjoelist.Add(employee);
            //        Console.WriteLine("employees : {0}", employee);

            //    }// this adds the joe found true and then adds the joes to the new list and then prints out the information console

            //}


            Console.ReadLine();
      }          
        
    }
}
