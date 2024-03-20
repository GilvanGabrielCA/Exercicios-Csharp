using System;
using System.Globalization;

namespace VetorMediaAritimeticaPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] ints = new int[N];

            string[] vet = Console.ReadLine().Split(' ');

            double soma = 0;
            double somaPares = 0;
            double media;
            for (int i = 0; i < N; i++) 
            {
                ints[i] = int.Parse(vet[i]);
                
                if (ints[i] % 2 == 0) 
                {
                    soma += ints[i];
                    somaPares++;
                }
            }

            media = soma / somaPares;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
