namespace SomaMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            int[,] a = new int[M, N];
            int[,] b = new int[M, N];
            int[,] c = new int[M, N];   

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) 
                {
                    a[i,j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    b[i, j] = int.Parse(s[j]);
                }
            }

            for(int i = 0;i < M; i++)
            {
                for(int j = 0;j < N; j++)
                {
                    c[i,j] = a[i,j] + b[i,j];
                }
            }

            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(c[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
