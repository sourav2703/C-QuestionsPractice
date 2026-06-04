using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations
{
    internal class Find_Duplicate_Words
    {
        string finalMassage = string.Empty;
        public string findIt(string str)
        {
            var words = str.Split(' ');
            var mydic = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if(!mydic.ContainsKey(word))
                {
                    mydic[word] = 1;
                }
                else
                {
                    mydic[word] = mydic[word] + 1;
                }
            }

            foreach (var word in mydic)
            {
                if(word.Value > 1)
                {
                    finalMassage=finalMassage + word.Key + ",";
                }
            }
            if(finalMassage != string.Empty)
            {
                finalMassage = finalMassage + " these are duplicates here \n";
            }
            else
            {
                finalMassage = "no duplicates";
            }
            return finalMassage;
        }
    }
}
