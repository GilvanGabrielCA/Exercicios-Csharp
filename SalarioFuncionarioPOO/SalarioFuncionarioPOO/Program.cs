using System;
using System.Globalization;

namespace SalarioFuncionarioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + fun);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            int porcentagem = int.Parse(Console.ReadLine());
            fun.AumentoSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + fun);
        }
    }
}
