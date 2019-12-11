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

        /// <summary>
        /// Calculate every possible multiplication between min (inclusive) and max (exclusive).
        /// Determines the highest possible value that's also a palindrome.
        /// </summary>
        /// <param name="min">Minimum value for multiplying. (inclusive)</param>
        /// <param name="max">Maximum value for multiplying. (exclusive)</param>
        /// <returns>The highest calculated palindrome result.</returns>
        int CalculatePalindromes(int min, int max)
        {
            int highestResult = -1;

            // The problem demands we check every possible multiplication of two numbers.
            // We'll have to use two loops instead of one.
            for (int x = min; x < max; x++)
            {
                for (int y = min; y < max; y++)
                {
                    int result = x * y;
                    // Check for possible palindrome.
                    if (IsPalindrome(result.ToString()))
                    {
                        Console.WriteLine("Found a palindrome: " + result.ToString());
                        // Higher than the previously stored record?
                        if (result > highestResult)
                            highestResult = result;
                    }
                }
            }

            // Quick check to ensure at least one valid palindrome was found.
            if (highestResult == -1)
                Console.WriteLine("WARNING! No valid palindromes were found.");

            return highestResult;
        }
    }
}
