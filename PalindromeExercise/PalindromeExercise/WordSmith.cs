using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        //This Method Reflects a Simpler Solution More In-Line with Best Practice
        public bool IsAPalindrome(string word)
        {
            string opposite = new string(word.Reverse().ToArray());
            return opposite.Equals(word);
        }

        //This Function was My Original Solution and Does Not Reflect Best Practice

        public bool WasAPalindrome(string word)
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
            }
            else if (size == 1)
            {
                return true;
            }
            else if (even == true)
            {
                checks = size / 2;
            }
            else
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
