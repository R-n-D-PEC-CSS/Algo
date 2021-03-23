using System;
using System.Collections.Generic;
using System.Text;

namespace Algos_in_C_Sharp.Basics
{
    public class BasicMathOperations
    {
        public static int AddNumbers(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        public static int SubtractNumbers(int numberOne,int numberTwo)
        {
            return (numberOne - numberTwo);
        }
        public static int multiplyNumbers(int numberOne,int numberTwo)
        {
            return numberOne * numberTwo;
        }
        public static double divideNumbers(int numberOne, int numberTwo)
        {
            if (numberTwo != 0)
            {
                return (double)numberOne / (double)numberTwo;
            }
            else
            {
                throw new DivideByZeroException("Can't divide by zero");
            }
        }

    }
}
