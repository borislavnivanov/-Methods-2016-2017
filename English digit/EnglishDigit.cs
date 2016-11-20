using System;

namespace English_digit
{
    class EnglishDigit
    {
        static string Transcription(char input)
        {
            string output = null;

            switch (input)
            {
                case '0':
                    output = "zero";
                    break;
                case '1':
                    output = "one";
                    break;
                case '2':
                    output = "two";
                    break;
                case '3':
                    output = "three";
                    break;
                case '4':
                    output = "four";
                    break;
                case '5':
                    output = "five";
                    break;
                case '6':
                    output = "six";
                    break;
                case '7':
                    output = "seven";
                    break;
                case '8':
                    output = "eight";
                    break;
                case '9':
                    output = "nine";
                    break;
                default:
                    output = "not a number";
                    break;
            }

            return output;
        }
        static void Main()
        {

            char[] input = Console.ReadLine().ToCharArray();
            string result = Transcription(input[input.Length - 1]);
            Console.WriteLine(result);
        }
    }
}
