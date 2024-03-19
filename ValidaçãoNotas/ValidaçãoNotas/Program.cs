using System;
using System.Globalization;

namespace ValidaçãoNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB, media;
            int validacao = 1;

            while (validacao != 2)
            {
                notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (notaA > 10 || notaA < 0)
                {
                    Console.WriteLine("nota invalida");
                    notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (notaB > 10 || notaB < 0)
                {
                    Console.WriteLine("nota invalida");
                    notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (notaA + notaB) / 2;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                
                
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                validacao = int.Parse(Console.ReadLine());

                while (validacao > 2 || validacao < 0)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    validacao = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
