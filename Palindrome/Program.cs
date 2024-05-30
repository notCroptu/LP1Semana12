using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                bool isPalindrome = IsPalindrome(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }
        static bool IsPalindrome(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));

            if (input.Length < 2) return true;
            
            bool CheckPalindrome(string input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (s[i] != s[input.Length - i]) return false;
                }
                return true;
            }

            return CheckPalindrome(input);
        }
    }
}
