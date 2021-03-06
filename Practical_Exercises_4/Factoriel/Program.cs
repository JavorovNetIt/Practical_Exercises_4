﻿using System;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                long factoriel = CalculateFactoriel(i);

                Console.WriteLine($"{i}! = {factoriel}");
            }
        }

        public static long CalculateFactoriel(int number)
        {
            long result = number;

            for (int i = number-1; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
