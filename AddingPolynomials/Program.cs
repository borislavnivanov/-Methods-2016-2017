using System;


namespace AddingPolynomials
{
    class Program
    {
        static int[] PopulateArray(int size, string[] stringArray)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = int.Parse(stringArray[i]);
            }
            return result;
        }
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            int[] arrayOne = PopulateArray(size, input1);
            int[] arrayTwo = PopulateArray(size, input2);
            for (int i = 0; i < size; i++)
            {
                int a = AddingPolynomials(arrayOne[i], arrayTwo[i]);
                Console.Write(a);
                if (i != size - 1)
                {
                    Console.Write(' ');
                }
            }
        }
        static int AddingPolynomials(int polinom1, int polinom2)
        {
            return polinom1 + polinom2;
        }
    }
}
