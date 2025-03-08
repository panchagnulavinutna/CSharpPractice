using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class CountPalindromes
    {
        public int CountNumberOfPalindromes(string n)
        {
            int c = 0;
            n = Regex.Replace(n, @"\s+", " ");
            foreach(string word in n.Split(' ')){
                if (!string.IsNullOrEmpty(word))
                {
                    if (IsPalindrome(word))
                    {
                        c++;
                    }
                }
            }
            return c;
        }
        public bool IsPalindrome(string x)
        {
            if (string.IsNullOrEmpty(x))
                return false;
            ReverseString rv = new ReverseString();
            char[] c = x.ToCharArray(); 
            char[] r = rv.reverse(c); 
            string rev = new string(r); 
            return x.Equals(rev, StringComparison.OrdinalIgnoreCase);
        }
    }
}
