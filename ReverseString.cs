using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class ReverseString
    {
        public char[] reverse(char[] s)
        {
            int i = 0, j = s.Length - 1;
            while (i <= j)
            {
                (s[i], s[j]) = (s[j], s[i]);
                i++;
                j--;
            }
            return s;
        }
    }
}
