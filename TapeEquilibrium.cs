using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class TapeEquilibrium {
    public int Solution(int[] A) {
        var N = A.Length;
        var sum = A.Sum();
        var tempSum = 0;
        int min = Math.Abs(sum);
        for(int i = 0; i < N; i++) {
            tempSum += A[i];
            min = Math.Min(min, Math.Abs(tempSum - (sum - tempSum)));
        }

        return min;
    }

    public static void Test()
    {
        var A = new int[] {1, 3, 4, 7, 9, -4000};
        var R = new TapeEquilibrium().Solution(A);
        Console.WriteLine("Result: "+  R);
    }
}