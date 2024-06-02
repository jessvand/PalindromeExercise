using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string words)
        {
        /*    var reverse = "";
            for(int i = words.Length-1; i >=0; i++)
            {
                reverse += words[i];
            }

          
            if (words.ToLower() == reverse.ToLower())
            {
                return true;

            }
            else
            {
                return false;
            }*/

            var wordToCharArr = words.ToCharArray();
            Array.Reverse(wordToCharArr);
            return words.SequenceEqual(wordToCharArr);
            
        }






    }
}
