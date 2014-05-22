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
            myApp.WhileStatementSamples();
            myApp.ForStatementSample();
            myApp.ListDivisibleBy(3);
            int someNumber;
            Console.WriteLine("Enter a small number between 2 and 20: ");
            someNumber = int.Parse(Console.ReadLine());
            myApp.ListDivisibleBy(someNumber);
            myApp.EnumSample(Color.Green);

            Console.WriteLine("Goodbye!");
            Console.WriteLine("Press [enter] to exit");
            Console.ReadLine();
        }
            
        
        public void IfStatementSample ()
            {
                Console.Write("If Statement Sample...");

                Console.WriteLine("Enter your age: ");
                string stringage = Console.ReadLine();
                int age = int.Parse(stringage);

                if (age >= 65)
                {
                    Console.WriteLine("You are a senior.");
                }
                else
                if (age >= 18)
                {
                    Console.WriteLine("You are an adult. ");
                }
                else
                {
                    Console.WriteLine("You are not an adult");
                }
            
            }

            private void ListDivisibleBy(int divisor)
            {
                Console.WriteLine("List all the numbers from 1 to 100 that a divisible by " + divisor);

                for (int counter = 1; counter <= 100; counter++)
                {
                    if (counter % divisor == 0)
                    {
                        Console.Write(counter);
                        Console.Write(", ");
                    }
                    Console.WriteLine();
                }

            }



            private void EnumSample(Color favoriteColor)
            {
                Console.WriteLine("Sample Enumberation....");
                
                switch (favoriteColor)
                {
                    case Color.Red:
                        Console.WriteLine("Your color is red.");
                        break;
                    case Color.Blue:
                        Console.WriteLine("Your color is blue.");
                        break;
                    case Color.Green:
                        Console.WriteLine("Your color is green.");
                        break;
                    default:
                        Console.WriteLine("You entered a different color: ");
                        Console.WriteLine(favoriteColor);
                        break;

                }
            }

            private void ForStatementSample()
            {
                Console.WriteLine("For Sample....");
                for (int counter = 1; counter < 10; counter++)
                {
                    Console.WriteLine(counter);
                }
            }


            public void WhileStatementSamples()
            {
                Console.WriteLine("While and Do-While Samples...");

                int counter = 10;
                while (counter > 0)
                {
                    Console.WriteLine(counter);
                    counter = counter - 1;
                }

                int age;
                do
                {
                    Console.WriteLine("Enter your age once more: ");
                    age = int.Parse(Console.ReadLine());

                } while (age < 1 || age > 100);
                string message;
                message = string.Format("You are {0} years old!", age);
                Console.WriteLine(message);
            }
        //end of the Main() method
    } //end of the Program class
}
//end of the namespace for this file's code
