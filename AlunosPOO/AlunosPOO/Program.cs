using System;
using System.Globalization;

namespace AlunosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno estudante = new Aluno();

            Console.Write("Nome do aluno: ");
            estudante.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            estudante.Nota1 = double.Parse(Console.ReadLine());
            estudante.Nota2 = double.Parse(Console.ReadLine());
            estudante.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + estudante.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (estudante.NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + estudante.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
