using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Remove_duplicates_from_array
    {
        public int findit()
        {
            var mynums = new int[] { 2, 5, 7, 20, 1, 2, 3, 4, 10, 20, 5, 7 };
            var result = new List<int>();
            var removedItem_fistApproach = mynums.Distinct();
            for (int i = 0; i < mynums.Length; i++)
            {
                if (!result.Contains(mynums[i]))
                {
                     result.Add(mynums[i]);
                }
            }


            return 1;
        }
    }
}
