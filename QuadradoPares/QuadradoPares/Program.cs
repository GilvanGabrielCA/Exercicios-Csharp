using System;

namespace QuadradoPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "^" + "2" + " = " + i * i);
                }
            }
        }
    }
}
