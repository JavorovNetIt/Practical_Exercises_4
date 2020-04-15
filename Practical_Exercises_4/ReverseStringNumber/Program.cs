using System;
using System.Linq;

namespace ReverseStringNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] massive = word.ToArray();

            //string reversed = ReverseText(word);
            Array.Reverse(massive);

            //Console.WriteLine(reversed);
            Console.WriteLine(string.Join("",massive));
        }

        public static string ReverseText(string text)
        {
            char[] reversed = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char x = text[i];

                reversed[text.Length - 1 - i] = x;
            }

            return string.Join("", reversed);
        }
    }
}
