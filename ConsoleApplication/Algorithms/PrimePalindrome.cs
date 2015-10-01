using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Algorithms
{
    //
    // Summary:
    //     Determines the largest prime palindrome less than the number provided.
    //     Can be played by replacing contents of Main with below and modifying number parameter.
    //     Full challenge description at https://www.codeeval.com/open_challenges/3/
    //
    // Returns:
    //     Largest prime palindrome less than the number provided.
    // 

    //static void Main(string[] args)
    //{
    //    Console.WriteLine(PrimePalindrome.GetPrimePalindrome(23409));
    //    Console.ReadLine();
    //}

    public static class PrimePalindrome
    {
        public static int GetPrimePalindrome(int num)
        {
            if (num < 1)
                throw new Exception("Number must be greater than 0.");

            if (num < 4)
                return num - 1;

            List<int> primes = new List<int>();

            // Start at 3 because it's the first prime palindrome number before the first non-prime number (4)
            // Increment by 2 because even numbers are not prime
            for (int i = 3; i < num; i += 2)
            {
                bool isPrime = true;

                // Loop through all existing previous prime numbers
                foreach (int prime in primes)
                {
                    // If current number is perfectly divisible by any prime, it's not prime
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // If current number wasn't divisible by any prime, it's prime
                if (isPrime)
                    primes.Add(i);
            }

            // Loop backwards through primes because largest number is required
            for (int j = primes.Count - 1; j >= 0; j--)
            {
                // If the current largest prime is a palindrome, return it
                if (Palindrome(primes[j]))
                    return primes[j];
            }

            throw new Exception("No prime palindrome number found");
        }

        private static bool Palindrome(int prime)
        {
            // If the prime is a single digit, it's automatically a palindrome
            if (prime < 10)
                return true;

            string str = prime.ToString();
            int start = 0;
            int end = str.Length - 1;

            // Loop through string representation of number, comparing first and last digits            
            while (start < end)
            {
                // If digits are not equal, the number is not a palindrome
                if (str[start] != str[end])
                    return false;
                start++;
                end--;
            }

            return true;
        }
    }
}
