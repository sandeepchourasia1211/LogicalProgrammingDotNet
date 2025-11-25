using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.CountAlphaDigiCharacters
{
    internal class AlphaDigiCharsCount
    {
        public AlphaDigiCharsCount() { }

        public static void countAlphaNumeric(String s)
        {
            int ac = 0, dc = 0, sc = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (Char.IsLetter(ch))
                    ac++;
                else if (Char.IsDigit(ch))
                    dc++;
                else
                    sc++;
            }


            // Without In-Built function

            //for (int i = 0; i < s.Length; i++)
            //{
            //    char ch = s[i];
               
            //    if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            //    {
            //        ac++;
            //    }                
            //    else if (ch >= '0' && ch <= '9')
            //    {
            //        dc++;
            //    }
            //    else
            //    {
            //        sc++;
            //    }
            //}

            Console.WriteLine($"Alphabets : {ac}");
            Console.WriteLine($"Digits : {dc}");
            Console.WriteLine($"Special Characters : {sc}");
        }
    }
}
