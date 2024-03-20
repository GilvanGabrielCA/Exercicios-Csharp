using System;
using System.Globalization;

namespace MaiorVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            double[] vet;
            
            vet = new double[N];

            string[] a = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) 
            {
                vet[i] = double.Parse(a[i], CultureInfo.InvariantCulture);
            }

            double maior = vet[0];
            int pos = 0;

            for (int i = 0; i < N; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    pos = i;
                }
            }


            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(pos);
        }
    }
}
