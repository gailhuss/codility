using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class PermCheck {
    public int Solution(int[] A) {
        var N = A.Length;
        var B = new bool[N + 1];
        
        for(int i = 0; i < N; i++) {
            var V = A[i];

            if(V < 1)
                return 0;
            if(V > N)
                return 0;
            
            if(B[V])
                return 0;

            B[V] = true;
        }
        
        return 1;
    }

    public static void Test()
    {
        var A = new int[] {7, 6, 2, 1, 5, 3, 4};
        var R = new PermCheck().Solution(A);
        Console.WriteLine("Result: " + R);

        A = new int[] {7, 7, 2, 1, 4, 3, 4};
        R = new PermCheck().Solution(A);
        Console.WriteLine("Result: " + R);

        A = new int[] {9, 5, 2, 1, 4, 3, 4};
        R = new PermCheck().Solution(A);
        Console.WriteLine("Result: " + R);
    }
}