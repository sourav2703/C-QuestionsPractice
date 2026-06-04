using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Find_largest_element
    {//Find largest element.
        public int findit()
        {
            var mynums = new int[] { 2, 3, 4 };
            //var maxword = mynums.Max();
            int maxnumber = mynums[0];

            for(int i = 1; i < mynums.Length; i++)
            {
                if (mynums[i] > maxnumber)
                {
                    maxnumber = mynums[i];
                }
            }
            return maxnumber;
        }
    }
}
