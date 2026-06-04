using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations
{
    internal class Find_the_longest_word_in_a_sentence
    {
        int biggest = 0;
        string finalMassage = string.Empty;
        public string findIt(string str)
        {
            var words = str.Split(' ');
            var mydic = new Dictionary<string, int>();
            foreach (var word in words)
            {
               mydic[word] = word.Length;
            }
            for (int i = 0; i < mydic.Count-1; i++)
            {
                   if(biggest < mydic[words[i]])
                    {
                        biggest = mydic[words[i]];
                    }
            }
            var data = mydic.FirstOrDefault(x=>x.Value== biggest).Key;
            return data.ToString();
        }
    }
}
