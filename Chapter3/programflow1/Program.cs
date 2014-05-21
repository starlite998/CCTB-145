using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programflow1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program myApp = new Program(); //Creates an object based on this class
            myApp.IfStatementSample(); //Call or execute the method

            Console.WriteLine("Goodbye!");
        }
            public void IfStatementSample ()
            {
                Console.Write("If Statement Sample...");

                Console.WriteLine("Enter your age: ");
                string stringage = Console.ReadLine();
                int age = int.Parse(stringage);

                if (age >= 18)
                {
                    Console.WriteLine("You are an adult. ");
                }
                else
                {
                    Console.WriteLine("You are not an adult");
                }
            
            }
        //end of the Main() method
    } //end of the Program class
}
//end of the namespace for this file's code
