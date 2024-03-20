using System;
using System.Globalization;

namespace MediasPonderadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());  

            for (int i = 0; i < N; i++)
            {
                double A, B, C, media;

                string[] vet = Console.ReadLine().Split(' ');

                A = double.Parse(vet[0], CultureInfo.InvariantCulture);  
                B = double.Parse(vet[1], CultureInfo.InvariantCulture);
                C = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = (A * 2 + B * 3 + C * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
