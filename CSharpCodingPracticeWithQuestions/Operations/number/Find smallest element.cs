using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{//Find smallest element.
    internal class Find_smallest_element
    {
        public int findit()
        {
            var mynums = new int[] { 2, 3, 4 };
            //var maxword = mynums.Max();
            int minnumber = mynums[0];

            for (int i = 1; i < mynums.Length; i++)
            {
                if (mynums[i] < minnumber)
                {
                    minnumber = mynums[i];
                }
            }
            return minnumber;
        }
    }
}
