using System;
using System.Collections.Generic;
using System.Linq;

namespace CoverletDemo.Calculation
{
    public class Calculation
    {

        public int Sum(List<int> arrayNumbers)
        {
            return arrayNumbers.Sum();
        }

        public int Sum2numbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Divide(int number1, int number2)
        {
            if(number2>0)
            {
                return number1 / number2;
            }

            return 0;
        }
    }
}
