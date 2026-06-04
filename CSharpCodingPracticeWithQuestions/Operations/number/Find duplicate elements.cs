using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Find_duplicate_elements
    {
        public int findit()
        {
            var mynums = new int[] { 2,2,5,7,20,1, 3, 4, 10, 20, 5, 7 };
            var result = new List<int>();
            var duplicate = mynums.GroupBy(x => x).Where(y => y.Count() > 1).Select(z => z.Key);
            for (int i = 0; i < mynums.Length; i++)
            {
                for ( int j = i+1;  j < mynums.Length ; j++)
                {
                    if (mynums[i] == mynums[j])
                    {
                        if (!result.Contains(mynums[j]))
                        {
                            result.Add(mynums[i]);
                        }
                    }
                }
            } 


            return 1;
        }
    }
}
