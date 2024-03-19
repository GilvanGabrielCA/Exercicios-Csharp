using System;

namespace SomaImparesConsecutivos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max, soma;

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                min = X;
                max = Y;
            }
            else
            {
                min = Y;
                max = X;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma +i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
