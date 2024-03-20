using System;

namespace Intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X, countIn, countOut;

            N = int.Parse(Console.ReadLine());

            countIn = 0;
            countOut = 0;
            
            for (int i = 0; i < N; i++) 
            {
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    countIn++;
                }
                else
                {
                    countOut++;
                }
            }

            Console.WriteLine(countIn + " in");
            Console.WriteLine(countOut + " out");
        }
    }
}
