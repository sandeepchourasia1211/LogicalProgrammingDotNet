using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.SumOfAllFactors
{
    internal class FactorsSum
    {
        public FactorsSum() { }

        public static void sumOfFactors(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            Console.WriteLine($"The Sum of All Factor of the Number {num} is {sum}");
        }
    }
}
