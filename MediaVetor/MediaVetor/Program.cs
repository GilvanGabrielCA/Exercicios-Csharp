using System;
using System.Globalization;

namespace MediaVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());

            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0;i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            double soma = 0, media;

            for (int i = 0; i < N; i++) 
            { 
                soma = soma + vet[i];
            }

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            media = soma / N;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
