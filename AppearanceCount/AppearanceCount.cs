using System;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static int GetDuplicateCount(int[] input, int x)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == x)
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
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            int result = GetDuplicateCount(array, search);
            Console.WriteLine(result);
        }
    }
}
