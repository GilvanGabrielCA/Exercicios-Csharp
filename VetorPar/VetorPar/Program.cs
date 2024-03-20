using System;
using System.Globalization;

namespace VetorPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet;

            vet = new int[N];

            string[] a = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(a[i]);
            }


            int soma = 0;
            for (int i = 0;i < N; i++)
            {
                if (vet[i] % 2 == 0) 
                {
                    Console.Write(vet[i] + " ");
                    soma++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(soma);
        }
    }
}
