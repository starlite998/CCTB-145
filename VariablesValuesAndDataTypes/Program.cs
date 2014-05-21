using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesValuesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order of operations + arithmetic operators
            double result = 5 + 6 * 4 + 1;

            //Variables of various data types with values
            Console.WriteLine("The result of the math is " + result);
            
            //What does casting really do??
            char singleDigit = '5';
            int simpleNumber = 25;

            //The result of casting
            Console.WriteLine("Casting 5.....");
            Console.WriteLine((int) singleDigit);
            Console.WriteLine("Casting 25....");
            Console.WriteLine((double)simpleNumber);

            //The result of converting
            Console.WriteLine("Converting 5.....");
            Console.WriteLine(Convert.ToInt32(singleDigit));
            Console.WriteLine("Converting 25....");
            Console.WriteLine(Convert.ToDouble(simpleNumber));

            //"alternate" way of converting using the parse method
            Console.WriteLine("Converting '5' using int Parse()");
            Console.WriteLine(int.Parse(singleDigit.ToString()));
            Console.WriteLine("The value in the variable SingleDigit is " + singleDigit.ToString());

            Console.WriteLine("Converting '5' after calling .ToString()");
            Console.WriteLine(Convert.ToInt32(singleDigit.ToString()));

            Console.WriteLine((int) result);


        }
    }
}
