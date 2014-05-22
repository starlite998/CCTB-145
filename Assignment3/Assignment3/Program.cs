using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            Program myApp = new Program();
            Console.Write("Please enter a number between 1 and 100: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 1 && number < 100)
            {
                int TotalEvenNumbers = 0;
                for (int counter = 1; counter <= number; counter++) 
                {
                   bool EvenNumber = IsEvenNumber(counter);

                   if (EvenNumber == true && counter <= number - 1)
                   {
                       TotalEvenNumbers = TotalEvenNumbers + counter;
                       Console.Write(counter + " + ");
                   }
                   else if (EvenNumber == true && counter >= number -1)
                   {
                       Console.Write(counter);
                       TotalEvenNumbers = TotalEvenNumbers + counter;
                   }
                }
                Console.Write(" = " + TotalEvenNumbers);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The number entered is not between 1 and 100!");
            }
        }

        static public bool IsEvenNumber(int intNumber)
        {
            return intNumber % 2 == 0;
        }
    }
}
