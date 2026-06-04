using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Check_Prime_Number
    {
        public int findit(int num = 7)
        {
            int count = 0;
            for(int i = 2; i <=num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                return 1;
            }
            return 0;
        }
    }
}
