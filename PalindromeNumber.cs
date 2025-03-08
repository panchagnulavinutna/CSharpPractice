using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            int a = reverse(x);
            if (a < 0) return false;
            if (a.Equals(x))
                return true;
            else
                return false;
        }
        public int reverse(int x)
        {
            int b = 0;
            while (x != 0)
            {
                if (b > int.MaxValue / 10 && b < int.MinValue / 10)
                {
                    return 0;
                }
                b = b * 10 + x % 10;
                x /= 10;
            }
            return b;
        }
    }
}
