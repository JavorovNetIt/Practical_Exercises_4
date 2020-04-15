using System;
using System.Runtime.CompilerServices;

namespace Neighbourghs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine($"Please enter {n} numbers of the array.");

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int index = int.Parse(Console.ReadLine());

            int number = numbers[index];

            int x = 0;

            int y = 0;

            if (index > 0)
            {
                x = numbers[index - 1];
            }

            if (index < numbers.Length -1)
            {
                y = numbers[index + 1];
            }

            if (number > x && number > y)
            {
                Console.WriteLine($"The number is greater than its neighbours");
            }
            else if (number < x && number < y)
            {
                Console.WriteLine($"The number is smaller than its neighbours");
            }
            else
            {
                Console.WriteLine("The number is not smaller or grater than its neighbours");
            }
        }
    }
}
