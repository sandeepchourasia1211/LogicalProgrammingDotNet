using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.PerfectNumberCheck
{
    internal class PerfectNumber
    {
        // Perfect numbers means Sum of all factors excluding itself number should be equals to original number.
        
        public PerfectNumber() { }

        public  bool checkPerfectNumber(int num)
        {
            int sum = 0;

            for (int i = 1; i < num/2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
           
            return sum==num;
        }
    }
}
