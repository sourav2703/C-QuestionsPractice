using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations
{//Count occurrences of each character.
    internal class Count_occurrences_of_each_character
    {
        string final = string.Empty;
        public string countIt(string word) //mango
        {
            word = word.ToLower().Trim();
            
            Dictionary<char, int> mydic = new Dictionary<char, int>();
            for(int i = 0; i < word.Length; i++)
            {
                if (char.IsLetterOrDigit(word[i]))
                {
                    if (mydic.ContainsKey(word[i]))
                    {
                        mydic[word[i]] = mydic[word[i]] + 1;
                    }
                    else
                    {
                        mydic[word[i]] = 1;
                    }
                }
               
            }

            foreach (var item in mydic)
            {
                final = final + item.Key + " = " + item.Value + "\n";
            }

            return final.Trim();
        }
    }
}
