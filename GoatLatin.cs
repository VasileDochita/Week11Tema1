using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Tema1
{
    namespace GoatLatin
    {
        public class GoatLatin
        {
            public string convertToGoatLatin(string s)
            {
                if (string.IsNullOrWhiteSpace(s))
                {
                    throw new ArgumentException("Value cannot be null or whitespace.", nameof(s));
                }
                var words = s.Split(' ');
                
                StringBuilder sb = new StringBuilder();
                
                int count = 0;
                
                foreach (string word in words)
                {
                    count++;
                    if (
                        word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' ||
                        word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U'
                    )
                    {
                        sb.Append(word);
                    }
                    else
                    {
                        for (int i = 1; i < word.Length; i++)
                            sb.Append(word[i]);
                        sb.Append(word[0]);
                    }
                    sb.Append("ma");

                    for (int i = 0; i < count; i++)
                    {
                        sb.Append('a');
                    }
                    if (count < words.Length)
                    {
                        sb.Append(' ');
                    }
                       
                }

                Console.WriteLine(sb.ToString());
                return sb.ToString();
            }

        }
    }
}
