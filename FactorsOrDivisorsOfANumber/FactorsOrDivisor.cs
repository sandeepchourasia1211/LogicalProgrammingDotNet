using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.FactorsOrDivisorsOfANumber
{
    internal class FactorsOrDivisor
    {
        FactorsOrDivisor() { }

        public static void factors(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    Console.WriteLine($"Factor is : {i}");
            }
        }
    }
}
