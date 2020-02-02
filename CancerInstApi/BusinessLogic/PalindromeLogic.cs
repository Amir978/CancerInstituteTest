using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CancerInstApi.BusinessLogic
{
    public class PalindromeLogic : IPalindromeLogic
    {
        public bool IsPalindrome(string phrase)
        {
            string cleanedPhrase = Sanitize(phrase);
            string reversedPhrase = DoReverse(cleanedPhrase);
            return cleanedPhrase == reversedPhrase;
        }

        public string Sanitize(string phrase)
        {
            var result = phrase.Trim();
            result = new Regex("[^a-zA-Z]").Replace(result, "").ToLower();

            return result;

        }
        public string DoReverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
    }
}
