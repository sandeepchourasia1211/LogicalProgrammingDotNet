using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFolder.StringReverse
{
    internal class ReverseString
    {
        public ReverseString() { }

        public String reverseString(String str)
        {
            String rev = "";
            
            for(int i=str.Length-1; i>=0; i--)
            {
                char ch = str[i];
                rev += ch;
            }
            
            return rev;

        }
    }
}
