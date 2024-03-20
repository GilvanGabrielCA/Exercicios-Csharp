using System;
using System.Globalization;

namespace ConjuntoDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            char[] sexo = new char[N];

            double somaAlturas = 0;
            double maiorAltura = double.MinValue;
            double menorAltura = double.MaxValue;
            int contHomens = 0;
            int contMulheres = 0;

            for (int i = 0; i < N; i++)
            {
                string[] x = Console.ReadLine().Split(' ');

                altura[i] = double.Parse(x[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(x[1]);

                if (sexo[i] == 'F')
                {
                    somaAlturas = somaAlturas + altura[i];
                    contMulheres++;
                }

                if (sexo[i] == 'M')
                {
                    contHomens++;
                }

                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }

                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }

            double mediaAlturas = somaAlturas / (double) contMulheres;
            Console.WriteLine("Menor Altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior Altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + mediaAlturas.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}
