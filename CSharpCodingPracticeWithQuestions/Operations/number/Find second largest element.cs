using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Find_second_largest_element
    {//Find second largest element.
        public int findit()
        {
            var mynums = new int[] { 2, 3, 4 , 10 , 20 , 5, 7};
            int max2num = mynums.Distinct().OrderByDescending(x => x).Skip(1).First();
            return max2num;
        }
    }
}
