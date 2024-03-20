using System;

namespace VetorMaisVelho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int maisVelho = 0;
            int indiceIdade = 0;

            string[] nome = new string[N];
            int[] idade = new int[N];

            

            for (int i = 0; i < N; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                nome[i] = x[0];
                idade[i] = int.Parse(x[1]);
                
                if (idade[i] > maisVelho)
                {
                    maisVelho = idade[i];
                    indiceIdade = i;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nome[indiceIdade]);
        }
    }
}
