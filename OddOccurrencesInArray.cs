using System;
using System.Linq;
namespace codility
{
    class OddOccurrencesInArray
    {
        public static void Test()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Odd Occurrences In Array Example");
            // var A = new int[] {9, 3, 9, 3, 9, 7, 42, 7};
            int unpaired;
            var A = FillArray(out unpaired);
            Console.WriteLine("A: " + A.Select(num => num.ToString()).Aggregate((first, second) => first + ", " + second));
            Console.WriteLine("N: " + A.Length);
            Console.WriteLine("U: " + unpaired);
            var R = new OddOccurrencesInArray().Solution(A);
            Console.WriteLine("Unpaired Element: " + R);
        }

        public int Solution(int[] A)
        {
            var N = A.Length;
            int R = 0; 
        
            for(int i = 0; i < N; i++)
                R ^= A[i];

            return R;
        }

        private static int[] FillArray(out int unpaird)
        {
            var rand = new Random();
            var N = rand.Next(1, 10000);
            N += (N % 2) ^ 1;
            var A = new int[N];
            var i = 0;
            for(i = 0; i < N / 2; i ++)
            {
                var V = rand.Next(1, 1000000);
                var j = i;
                while(A[j] != 0)
                    j = (j + 1) % N;
                A[j] = V;

                j = rand.Next(N);
                while(A[j] != 0)
                    j = (j + 1) % N;
                A[j] = V;
            }

            for(i = 0; A[i] != 0; i++);
            A[i] = unpaird = rand.Next(1000000);

            return A;
        }
    }
}