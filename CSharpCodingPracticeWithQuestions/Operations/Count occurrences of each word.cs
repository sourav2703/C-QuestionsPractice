using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations
{//Count occurrences of each character.
    internal class Count_occurrences_of_each_word
    {
        public string countIt(string str)
        {
            string finalMessage = string.Empty;
            string [] data = str.Split(' ');
            var mydic = new Dictionary<string, int>();
            foreach (var word in data)
            {
                if (mydic.ContainsKey(word))
                {
                    mydic[word] = mydic[word] + 1;
                }
                else
                {
                    mydic[word] = 1;
                }
            }

            foreach (var item in mydic)
            {
                finalMessage = finalMessage + item.Key + " contains " + item.Value +"times \n";
            }
            return finalMessage;
        }
    }
}
