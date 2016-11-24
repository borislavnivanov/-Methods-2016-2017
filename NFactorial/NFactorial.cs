using System;
using System.Numerics;


namespace NFactorial
{
    class NFactorial
    {
        static BigInteger GetN(int input)
        {
            BigInteger result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = GetN(number);
            Console.WriteLine(result);
        }
    }
}
