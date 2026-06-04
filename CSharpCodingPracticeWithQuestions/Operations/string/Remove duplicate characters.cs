using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations
{
    internal class Remove_duplicate_characters
    {
        string finalMassage = string.Empty;
        public string findIt(string str)
        {
            var mydic = new Dictionary<char, int>();
            foreach (var ch in str)
            {
                if (!mydic.ContainsKey(ch))
                {
                    mydic[ch] = 1;
                }
                else
                {
                    mydic[ch] = mydic[ch] + 1;
                }
            }

            foreach (var word in mydic)
            {
                if (word.Value == 1)
                {
                    finalMassage = finalMassage + word.Key;
                }
            }
            if (finalMassage == string.Empty)
            {
                finalMassage = "no duplicates";

            }
            return finalMassage;
        }
    }
}
