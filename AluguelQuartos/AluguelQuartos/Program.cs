namespace AluguelQuartos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] vetor = new Estudantes[10]; 

            Console.Write("Quantos quartos serao alugados? ");
            int QuartosAlugados = int.Parse(Console.ReadLine());

            for (int i = 1; i <= QuartosAlugados; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Alugel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudantes(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }
        }
    }
}
