using System;
using System.Globalization;

namespace LeituraDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idade = new int[N];
            double[] altura = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
                altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            double somaAlturas = 0;
            double media;

            for (int i = 0; i < N; i++)
            {
                somaAlturas += altura[i];
            }

            media = somaAlturas / N;

            int contIdades = 0;
            for (int i = 0;i < N; i++) 
            {
                if (idade[i] > 16) 
                {
                    contIdades++;
                }
            }

            double porcentIdade = (double) contIdades / N * 100.0;

            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentIdade.ToString("F0", CultureInfo.InvariantCulture) + "%");
        }
    }
}
