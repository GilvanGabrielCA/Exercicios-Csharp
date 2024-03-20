using System;
using System.Globalization;

namespace VetorMediaNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            double[] notaP1 = new double[N];
            double[] notaP2 = new double[N];
            double[] media = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                nome[i] = x[0];
                notaP1[i] = double.Parse(x[1], CultureInfo.InvariantCulture);
                notaP2[i] = double.Parse(x[2], CultureInfo.InvariantCulture);
                media[i] = (notaP1[i] + notaP2[i]) / 2 ;
            }


            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0;i < N; i++)
            {
                if (media[i] >= 6)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}
