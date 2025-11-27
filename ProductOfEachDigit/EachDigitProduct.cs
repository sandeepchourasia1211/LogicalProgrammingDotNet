using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.ProductOfEachDigit
{
    internal class EachDigitProduct
    {
        public EachDigitProduct() { }

        public long productOfNumber(int num)
        {
            long prod = 1;

            while(num>0)
            {
                int temp = num % 10;
                prod *= temp;
                num/=10;
            }
            return prod;
        }
    }
}
