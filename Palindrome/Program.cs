using System;

namespace Palindrome
{
    /// <summary>
    /// This application is based on Project Euler's palindrome problem.
    /// https://projecteuler.net/problem=4
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Reverse a given string.
        /// </summary>
        /// <param name="input">Input string to be reversed.</param>
        /// <returns>Same as input string but in reverse.</returns>
        String ReverseString(String input)
        {
            // Convert input string into a character array.
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            // String class has a constructor to convert a char array to string.
            return new string(chars);
        }

        /// <summary>
        /// Check a given string to determine whether it's a palindrome.
        /// (The string must be identical when reversed.)
        /// </summary>
        /// <param name="input">Input string to check.</param>
        /// <returns>Boolean as result, true if the input string is a possible palindrome.</returns>
        bool IsPalindrome(String input)
        {
            return (input == ReverseString(input));
        }
    }
}
