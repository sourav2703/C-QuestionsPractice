using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations
{// find duplicate charactor
    internal class Find_Duplicate_Characters
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

            foreach(var c in mydic)
            {
                if(c.Value > 1)
                {
                    finalMessage = finalMessage + c.Key + " , ";
                }
            }
            if(finalMessage!=string.Empty)
            {
                finalMessage = finalMessage + " are duplicates";
            }
            else
            {
                finalMessage = "no duplicates found";
            }
            return finalMessage;
        }
    }
}
