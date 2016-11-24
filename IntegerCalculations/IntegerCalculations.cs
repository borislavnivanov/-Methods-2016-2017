using System;


namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] array = PopulateArray(input.Length, input);
            int min = GetMin(array);
            int max = GetMax(array);
            double average = GetAverage(array);
            int sum = GetSum(array);
            long product = GetProduct(array);
            //Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}", min, max, average, sum, product);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine("{0:F2}", average);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }

        private static long GetProduct(int[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum *= array[i];
            }
            return sum;
        }

        private static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        private static double GetAverage(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum = sum / array.Length;
            return sum;
        }

        private static int GetMax(int[] array)
        {
            Array.Sort(array);
            return array[array.Length - 1];
        }

        private static int GetMin(int[] array)
        {
            Array.Sort(array);
            return array[0];
        }

        static int[] PopulateArray(int size, string[] stringArray)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = int.Parse(stringArray[i]);
            }
            return result;
        }

    }
}
