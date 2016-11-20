using System;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static int GetMax(int[] input)
        {
            int maxInt = 0;
            maxInt = Math.Max(input[0], input[1]);
            maxInt = Math.Max(maxInt, input[2]);
            return maxInt;
        }
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int[] numArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numArray[i] = int.Parse(numbers[i]);
            }
            int result = GetMax(numArray);
            Console.WriteLine(result);
        }
    }
}
