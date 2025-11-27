using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.EvenDigitPresent
{
    internal class EvenDigit
    {
        public EvenDigit() { }

        public int CountEvenDigit(int num)
        {
            int count = 0;
            while(num > 0)
            {
                int temp = num % 10;

                if(temp%2==0)
                {
                    count++;                    
                }
               
                num /= 10;
            }
            return count;
        }
    }
}
