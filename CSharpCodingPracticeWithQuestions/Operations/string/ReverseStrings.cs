using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions
{
    //Reverse a string without using built-in methods.

    internal class ReverseStrings
    {
        public string ReverseIt(string str)
        {
            string newWord = string.Empty;
            for (int i = str.Length-1; i >= 0; i--)
            {
                newWord += str[i];
            }
            return newWord;
        }
    }
}
