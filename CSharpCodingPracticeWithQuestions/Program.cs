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


            var obj = new CheckPalindromString();
            Console.WriteLine(obj.checkIt("mama"));
            Console.ReadLine();
        }
    }

  
        
}
