using System;

namespace SomaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A;
            int[] B;
            int[] C;

            A = new int[N];
            B = new int[N];
            C = new int[N];

            string[] x = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(x[i]);
            }

            x = Console.ReadLine().Split(' ');
            for (int i = 0;i < N; i++)
            {
                B[i] = int.Parse(x[i]);
            }
        
            for(int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }

            
        }
    }
}
