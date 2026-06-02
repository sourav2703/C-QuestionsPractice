using CSharpCodingPracticeWithQuestions.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var obj = new ReverseWords();
            //Console.WriteLine(obj.ReverseIt("My Name is Sourav"));
            //Console.ReadLine();


            //var obj = new ReverseStrings();
            //Console.WriteLine(obj.ReverseIt("Sourav"));
            //Console.ReadLine();


            //var obj = new CheckPalindromString();
            //Console.WriteLine(obj.checkIt("mama"));
            //Console.ReadLine();

            //var obj = new Count_vowels_and_consonants();
            //Console.WriteLine(obj.countIt("mama"));
            //Console.ReadLine();

            //var obj = new Count_occurrences_of_each_character();
            //Console.WriteLine(obj.countIt("i am sourav 1222"));
            //Console.ReadLine();

            //var obj = new Count_occurrences_of_each_word();
            //Console.WriteLine(obj.countIt("i am sourav sourav"));
            //Console.ReadLine();

            //var obj = new Find_Duplicate_Characters();
            //Console.WriteLine(obj.findIt("apple"));
            //Console.ReadLine();

            //var obj = new Find_first_repeated_character();
            //Console.WriteLine(obj.findIt("whatisthis"));
            //Console.ReadLine();

            //var obj = new Find_first_non_repeated_character();
            //Console.WriteLine(obj.findIt("whatisthis"));
            //Console.ReadLine();

            //var obj = new Remove_duplicate_characters();
            //Console.WriteLine(obj.findIt("whatisthis"));
            //Console.ReadLine();

            var obj = new Find_the_longest_word_in_a_sentence();
            Console.WriteLine(obj.findIt("I love programming in csharp"));
            Console.ReadLine();
        }
    }

  
        
}
