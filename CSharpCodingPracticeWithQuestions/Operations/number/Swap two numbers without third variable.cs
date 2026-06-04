using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeWithQuestions.Operations.number
{
    internal class Swap_two_numbers_without_third_variable
    {
        public int findit()
        {
            int num1 = 7;  //3
            int num2 = 3; //7

            //int temp = num1;
            //num1= num2;
            //num2 = temp;

            num1 = num1 + num2; //10
            num2 = num1 - num2; // 7
            num2 = num1 - num2; //3

            return 0;
        }
    }
}
