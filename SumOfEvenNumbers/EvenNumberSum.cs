using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.SumOfEvenNumbers
{
    internal class EvenNumberSum
    {
        public EvenNumberSum() { }

        public static void SumOfEven(int num)
        {
            int sum = 0;
            for(int i = 2; i <= num; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine($"The sum of Even Digits between 1 to {num} is {sum}");
        }
    }
}
