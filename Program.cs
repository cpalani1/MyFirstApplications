using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my First Programe");
            Console.WriteLine("Enter you're name :");
            String SomeDataFromusers = Console.ReadLine();
            try
            {
                if (SomeDataFromusers.Length == 0)
                {
                    throw new Exception("Name should be blank!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //Console.ReadLine();
                return;
            }
            Console.WriteLine("Enter you're age:");
            int Age = 0;
            try
            {
                if (int.TryParse(Console.ReadLine(),out Age)) {
                    Console.WriteLine("You're name is " + SomeDataFromusers + " and age is " + Age);
                    Console.ReadLine();
                }
                else { 
                 throw new Exception("You're Age should be numberic");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
               // Console.ReadLine();
                return;
            }
        }
    }
}
