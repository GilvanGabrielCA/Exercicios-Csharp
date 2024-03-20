using System;
using System.Globalization;

namespace VetorMediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];
            double media, soma = 0;

            string[] a = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(a[i], CultureInfo.InvariantCulture);
                soma += vet[i];
            }

            media = soma / N;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for(int i = 0; i < N; i++) 
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
