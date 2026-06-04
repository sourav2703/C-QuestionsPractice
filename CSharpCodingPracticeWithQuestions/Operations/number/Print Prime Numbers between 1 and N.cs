using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Print_Prime_Numbers_between_1_and_N
    {
        public int findit(int num = 7)
        {
            var primes = new List<int>();
            int count = 0;
            for(int j= 1; j<= num; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    primes.Add(j);
                }
                count = 0;
            }
         
           
            return 0;
        }
    }
}
