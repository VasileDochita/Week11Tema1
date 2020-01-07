using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsProblem
{
    public class StringsReverse
    {
        public string reverseOnlyLetters(string S)
        {
            if (string.IsNullOrWhiteSpace(S))
            {
                throw new ArgumentNullException(nameof(S));
            }
                
            S = S.Trim();
            int start = 0;
            int end = S.Length - 1;
            char[] CharArray = S.ToCharArray();

            while (start < end)
            {
                if (char.IsLetter(CharArray[start]) && char.IsLetter(CharArray[end]))
                {
                    char temp = CharArray[start];
                    CharArray[start] = CharArray[end];
                    CharArray[end] = temp;
                    start++;
                    end--;
                }
                if (!char.IsLetter(CharArray[start]))
                {
                    start++;
                }

                if (!char.IsLetter(CharArray[end]))
                {
                    end--;
                }
            }

            return new string(CharArray);
        }
    }
}
