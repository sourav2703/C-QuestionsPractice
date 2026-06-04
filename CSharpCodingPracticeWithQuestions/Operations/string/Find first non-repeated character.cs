using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations
{//Find first non-repeated character.
    internal class Find_first_non_repeated_character
    {
        string finalMessage = string.Empty;
        public string findIt(string str)
        {
            var mydic = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!mydic.ContainsKey(c))
                {
                    mydic[c] = 1;
                }
                else
                {
                    mydic[c] = mydic[c] + 1;
                }
            }

            foreach (var c in mydic)
            {
                if (c.Value == 1)
                {
                    finalMessage = c.Key.ToString();
                    break;
                }
            }
            if (finalMessage != string.Empty)
            {
               finalMessage = finalMessage + " Find first non-repeated character.";
            }
            else
            {
                finalMessage = "no Find first non-repeated character. found";
            }
            return finalMessage;
        }
    }
}
