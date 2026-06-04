using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions
{
    //Reverse a words ( sentance ) without using built-in methods.
    internal class ReverseWords
    {
        public string ReverseIt(string sentance)
        {
            string [] word = sentance.Split(' ');
            string newword = string.Empty;
            for (int i = word.Length-1; i >= 0; i--)
            {
                newword += word[i] + " ";
            }
            return newword.TrimEnd();
        }
    }
}
