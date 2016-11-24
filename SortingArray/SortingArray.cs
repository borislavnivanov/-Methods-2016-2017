using System;


namespace SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}", array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            
        }
    }
}
