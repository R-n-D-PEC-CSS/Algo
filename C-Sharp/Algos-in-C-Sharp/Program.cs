using System;
using Algos_in_C_Sharp.Basics;
namespace Algos_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BasicMathOperations.AddNumbers(10, 20));
            Console.WriteLine(BasicMathOperations.SubtractNumbers(10, 20));
            Console.WriteLine(BasicMathOperations.multiplyNumbers(3, 4));
            Console.WriteLine(BasicMathOperations.divideNumbers(1, 2));
            try
            {
                BasicMathOperations.divideNumbers(1, 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
