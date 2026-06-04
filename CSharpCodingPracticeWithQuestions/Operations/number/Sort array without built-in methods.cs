using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Sort_array_without_built_in_methods
    {
        public int findit()
        {
            int[] mynums = new int[] { 3,5,7,2 };
            var sorted = mynums.OrderBy(x => x);
           
            return 1;
        }
    }
}
