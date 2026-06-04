using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Reverse_an_array
    {
        public int findit()
        {
            int[] mynums = new int[] { 2, 5, 7, 20, 1, 2, 3, 4, 10, 20, 5, 7 };
            var result = new List<int>();
            //Array.Reverse(mynums);
            for (int i = mynums.Length-1; i >=0; i--)
            {
               
                    result.Add(mynums[i]);
            }


            return 1;
        }
    }
}
