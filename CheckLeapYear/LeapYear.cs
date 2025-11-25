using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.CheckLeapYear
{
    internal class LeapYear
    {
        public LeapYear() { }

        public static void isLeapYear(int  year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine($"The year {year} is LeapYear");
            else
                Console.WriteLine($"The year {year} is not a LeapYear");
        }
    }
}
