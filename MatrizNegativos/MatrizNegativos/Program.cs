using System;

namespace MatrizNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');

            int M = int.Parse(a[0]);
            int N = int.Parse(a[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0;i < M; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}
