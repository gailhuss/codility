using System;
using System.Linq;

namespace codility{
    class CyclicRotation { 
        public static void Test()
        {
            var random = new Random();
            var N = random.Next(0, 100);
            var K = random.Next(0, 100);
            var A = new int[N];
            for(int i = 0; i < N; i++)
                A[i] = random.Next(-1000, 1000);
            
            Console.WriteLine("=======================");
            Console.WriteLine("Cyclic Rotation Example");
            Console.WriteLine("A: " + A.Select(num => num.ToString()).Aggregate((first, second) => first + ", " + second));
            Console.WriteLine("K: " + K);
            var R = new CyclicRotation().Solution(A, K);
            Console.WriteLine("R: " + R.Select(num => num.ToString()).Aggregate((first, second) => first + ", " + second));
        }

        public int[] Solution(int[] A, int K)
        {
            //Example
            // A = [3, 8, 9, 7, 6, 5]
            // K = 3
            // [7, 6, 5, 3, 8, 9]
            var N = A.Length;
            if(N == K)
                return A;

            K = K % N;

            var result = new int[A.Length];

            
            for(int i = 0; i < N; i++)
            {
                var newIndex = (i + K) % N;
                result[newIndex] = A[i];
            }

            return result;
        } 
    }
}