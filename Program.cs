using CSharpPractice;

namespace CSharpPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Reverse of a string\nEnter input string: ");
            char[] str = Console.ReadLine().ToLower().ToCharArray();
            ReverseString rs = new ReverseString();
            char[] res = rs.reverse(str);
            Console.WriteLine($"The reverse of the given input is : {new string(res)}");

            Console.WriteLine("2. Palindrome of a number");
            int x = int.Parse(Console.ReadLine());
            PalindromeNumber pd = new PalindromeNumber();
            bool n = pd.IsPalindrome(x);
            if (n)
                Console.WriteLine($"The number {x} is a Palindrome");
            else
                Console.WriteLine($"The number {x} is not a Palindrome");

            Console.WriteLine($"3. Count the number of Palindromes in a string\nEnter string");
            string s = Console.ReadLine().ToLower();
            CountPalindromes cp = new CountPalindromes();
            int count = cp.CountNumberOfPalindromes(s);
            Console.WriteLine($"The number of palindromes in the given string is: {count}");


            Console.WriteLine($"4. Smallest element in the array\nEnter the size of the arrays: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of the array: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            SmallestElement se = new SmallestElement();
            int min = se.Smallest(arr);
            Console.WriteLine($"Smallest element in the array is {min}");
        }
    }
}