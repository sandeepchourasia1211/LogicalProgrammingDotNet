using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.FactorialOfANumber
{
    internal class Factorial
    {
        public Factorial() { }
        public  long factorialOfNumber(int num)
        {
            long prod = 1;

            for(int i=num;i>=1;i--)
            {
                prod *= i;
            }
            return prod;
        }
    }
}
