namespace Grenais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golInter, golGremio, contGrenal, contVitInter, contVitGremio, contEmpate, validacao;

            validacao = 1;
            contGrenal = 0;
            contVitInter = 0;
            contVitGremio = 0;
            contEmpate = 0;

            while (validacao != 2)
            {
                string[] vet = Console.ReadLine().Split(' ');

                golInter = int.Parse(vet[0]);
                golGremio = int.Parse(vet[1]);

                if (golInter > golGremio)
                {
                    contVitInter += 1;
                    contGrenal += 1;
                }
                else if (golInter < golGremio)
                {
                    contVitGremio += 1;
                    contGrenal += 1;
                }
                else
                {
                    contEmpate += 1;
                    contGrenal += 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                validacao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(contGrenal + " grenais");
            Console.WriteLine("Inter:" + contVitInter);
            Console.WriteLine("Gremio:" + contGrenal);
            Console.WriteLine("Empates:" + contEmpate);
            if (contVitInter > contVitGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (contGrenal > contVitGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houuve vencedor");
            }
        }
    }
}
