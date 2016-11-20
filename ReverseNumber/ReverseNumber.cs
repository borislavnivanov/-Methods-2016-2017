using System;


namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            string result = new string(input);
            Console.WriteLine(result);

        }
    }
}
