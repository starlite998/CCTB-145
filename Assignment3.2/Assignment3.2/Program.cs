using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int outerLoop;

            for (int counter = 5; counter > 0 && counter <= 5 ; counter--)
            {
                outerLoop = counter;
                
                for (int innerloop = 1; innerloop < 4; innerloop++)
                {
                    int innerresult = counter * innerloop;
                    
                    if (innerresult != 5)
                    {
                        Console.WriteLine(innerresult);
                    }
                }

                Console.WriteLine(outerLoop);
            }
             

        }
    }
}
