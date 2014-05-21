using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_lisa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool attendingSchool = false;
            bool workingFullTime = true;

            string name = "Lisa";
            string city = "Edmonton";

            int yearsCollege = 1;
            int yearsUniversity = 4;

            int totalPostSecondaryYears = yearsCollege + yearsUniversity;

            bool attendingSchoolandWorking = attendingSchool && workingFullTime;
            bool moreThan4YearsPostSecondary = totalPostSecondaryYears > 4;
            bool hardWorkingOrSmart = true;

            Console.WriteLine("Name " + name + " from  " + city);
            Console.WriteLine("Attending School and Working: " + attendingSchoolandWorking);
            Console.WriteLine("More than 4 years of Post Secondary: " + moreThan4YearsPostSecondary);
            Console.WriteLine("Hard Working or Smart: " + hardWorkingOrSmart);

        }
    }
}
 