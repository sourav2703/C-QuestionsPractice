using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations
{
    internal class Count_vowels_and_consonants
    {//Count vowels and consonants.
        public string countIt( string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int vowelCount = 0;
            int consonantCount =0;

            foreach (var eachChar in str.ToLower())
            {
                if (char.IsLetter(eachChar))
                {
                    if (vowels.Contains(eachChar))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
                
            }
            return "vowel is " + vowelCount + "consonent is " +consonantCount;
        }

    }
}
