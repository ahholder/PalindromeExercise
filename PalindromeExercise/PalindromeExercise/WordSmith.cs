using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //Establish baseline
            int size = word.Length;
            int checks = 0;
            bool even = false;
            char c1 = 'x';
            char c2 = 'x';
            //Determine even or odd number of characters
            if (size % 2 == 0) even = true;
            //Establish final check
            if (size <= 0)
            {
                return false;
            } else if (size == 1)
            {
                return true;
            } else if (even == true)
            {
                checks = size / 2;
            } else
            {
                checks = (size - 1) / 2;
            }
            //Perform final check
            for (int i = 0; i < checks; i++)
            {
                c1 = word[i];
                c2 = word[size - 1 - i];
                if (c1 != c2) return false;
            }
            return true;
        }
    }
}
