using System;

namespace MaiorCadaLinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N]; 

            

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            for(int i = 0;i < N; i++)
            {
                int maior = int.MinValue;
                for (int j = 0;j < N; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}
