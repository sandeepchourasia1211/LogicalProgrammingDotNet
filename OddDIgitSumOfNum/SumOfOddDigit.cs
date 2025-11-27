using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.OddDIgitSumOfNum
{
    internal class SumOfOddDigit
    {
        public SumOfOddDigit() { }

        public int oddSum(int num)
        {
            int sum = 0;

            while(num>0)
            {
                int temp = num % 10;

                if(temp%2!=0)
                    sum += temp;

                num /= 10;
            }
            return sum;
        }
    }
}
