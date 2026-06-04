using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions
{ //Check if a string is palindrome.
    internal class CheckPalindromString
    {
        public bool checkIt(string str)
        {
            str=str.ToLower();
            char[] ch = str.ToCharArray();
            string newStr = string.Empty;
            Array.Reverse(ch);
            newStr = new string(ch);
            return str==newStr;
        }
    }
}
