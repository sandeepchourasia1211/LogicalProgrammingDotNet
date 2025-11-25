using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.PowerOfNP
{
    internal class NPPower
    {
        public NPPower() { }

        public long powerOfNP(int num,int pow)
        {
            long prod = 1;

            for(int i = 1; i <= pow; i++)
            {
                prod *= num;
            }
            return prod;
        }
    }
}
