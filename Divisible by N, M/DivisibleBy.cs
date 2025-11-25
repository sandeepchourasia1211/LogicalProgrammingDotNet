using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.Divisible_by_N__M
{
    internal class DivisibleBy
    {
        //Sanju if divisible by 3
        //Geeta if divisible by 5
        //Geeta won by Sanju if divisible by 3&5

        public DivisibleBy() { }
        public static void divisibleBy(int num)
        {
            int n1 = 3, n2 = 5;

            if(num%n1==0 && num%n2==0)
            {
                Console.WriteLine("Geeta won by Sanju");
            }
            else if(num%n1==0 )
            {
                Console.WriteLine("Sanju ");
            }
            else if( num%n2==0 ) 
            {
                Console.WriteLine("Geeta");
            }
            else
            {
                Console.WriteLine($"The Number {num} is not divisible by {n1} or {n2}");
            }
        }
    }
}
