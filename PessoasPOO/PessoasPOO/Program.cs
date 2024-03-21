namespace PessoasPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaX = new Pessoa(); 
            Pessoa pessoaY = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoaX.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaX.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoaY.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaY.Idade = int.Parse(Console.ReadLine());

            if (pessoaX.Idade > pessoaY.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoaX.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoaY.Nome);
            }
        }
    }
}
