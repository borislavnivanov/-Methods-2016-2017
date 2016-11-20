using System;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static int LargerNeighbour(int[] input)
        {
            int count = 0;
            for (int i = 1; i < input.Length - 1; i++)
            {
                if (input[i] > input[i - 1] && input[i] > input[i + 1])
                {
                    count++;
                }
               
            }
            return count;
        }

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            int result = LargerNeighbour(array);
            Console.WriteLine(result);
        }
    }
}
