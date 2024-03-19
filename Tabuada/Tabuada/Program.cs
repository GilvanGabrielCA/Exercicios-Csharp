namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(i + " x " + N + " = " + i * N);
            }
        }
    }
}
