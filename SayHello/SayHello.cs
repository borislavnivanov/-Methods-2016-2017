using System;


namespace SayHello
{
    class SayHello
    {
        static void Print(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            string input = Console.ReadLine();
            Print(input);
        }
    }
}
