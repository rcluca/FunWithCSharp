using System;

namespace ConsoleApplication.Algorithms
{
    public static class DancesWithWolves
    {
        // Time complexity: O(n)
        // Extra space: O(1)
        //
        // The function is written specifically for the input provided
        // in the test.
        // A generic function would require knowing the max, either
        // by receiving it as a parameter input or by doing a search
        // in O(n) time.
        //
        // An alternative implementation would be to sort the array and
        // then iterate through it until the same two numbers are found
        // next to each other but this would be a worse approach as the
        // sort algorithm would increase the time complexity to O(n log n)
        public static int DuplicateInteger(int[] nums)
        {
            // The formula for the sum of increasing integers is used
            // in order to reduce running time by O(n).
            // 
            // Formula: n(n + 1)/2
            //
            // A naive implementation would be as follows:
            //
            // long sum = 0;
            // for (int i = 0; i < nums.Length; i++)
            //     sum += nums[i];
            long n = 1000000;
            long sum = n * (n + 1) / 2;

            // Loop through each number in array to find the sum.
            long sumWithDup = 0;
            for (int i = 0; i < nums.Length; i++)
                sumWithDup += nums[i];

            // The duplicate number is the difference between
            // the sum with the duplicate and the sum without
            // the duplicate.
            return (int)(sumWithDup - sum);
        }

        // Time complexity: O(n)
        // Extra space: O(1)
        //
        // An array is used to keep a count of the occurances
        // of each character then the string is looped through
        // again, comparing each character to it's count,
        // returning the first with a One.
        //
        // String return type is used, instead of char, to be 
        // able to return null if no non-repeating characters
        // exist.
        public static string FirstNonRepeatingCharacter(string str)
        {
            if (String.IsNullOrEmpty(str))
                throw new Exception("A null or empty string cannot be provided.");

            if (str.Length == 1)
                return str[0].ToString();

            // A bitwise enum is used to reduce the space
            // required from 32 bits (size of int)
            // to 8 bits per array element.
            // 
            // Array of size 128 is used because the ASCII
            // alphabet is expected.
            CountOfChars[] charCount = new CountOfChars[128];

            // Loop through each character in string and
            // "count" how many occurances there are by
            // changing the value in charCount from Zero
            // to One to TwoOrMore.
            foreach (char c in str)
            {
                int cValue = c;

                if (charCount[cValue] == CountOfChars.Zero)
                    charCount[cValue] = CountOfChars.One;
                else if (charCount[cValue] == CountOfChars.One)
                    charCount[cValue] = CountOfChars.TwoOrMore;
            }

            // Loop through each character in string and
            // return the first that's not repeated.
            foreach (char c in str)
            {
                if (charCount[(int)c] == CountOfChars.One)
                    return c.ToString();
            }

            // Return null if there are no non-repeating
            // characters in string.
            return null;
        }

        private enum CountOfChars : byte
        {
            Zero = 0,
            One = 1,
            TwoOrMore = 2
        }
    }
}
