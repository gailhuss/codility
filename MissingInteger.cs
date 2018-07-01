using System;

namespace codility
{
    class MissingInteger
    {
            public int Solution(int[] A)
            {
                int N = A.Length;
                bool[] B = new bool[N + 1];

                for(int i = 0; i < N; i++)
                {
                    if(A[i] < 1 || A[i] > N)
                        continue;

                    B[A[i]] = true;
                }

                for(int i = 1; i <= N; i++)
                {
                    if(B[i] == false)
                        return i;
                }

                return N + 1;
            }

            public static void Test()
            {
                var missingInteger = new MissingInteger();

                int[] A = new int[] {1,3,6,4,1,2};
                int result = missingInteger.Solution(A);
                TestBuddy.PrintTestResult(5, result);

                A = new int[] {3,6,4,1,2,5,7};
                result = missingInteger.Solution(A);
                TestBuddy.PrintTestResult(8, result);
                
                A = new int[] {3,6,4,1000,2, -2, 0 };
                result = missingInteger.Solution(A);
                TestBuddy.PrintTestResult(1, result);
            }
    }
}