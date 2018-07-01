using System;
using System.Linq;

namespace codility{
class FrogRiverOne {
    public int Solution(int X, int[] A) {
        var N = A.Length;
        if(N < X)
            return -1;

        var reqCover = (X * (1 + X) / 2);
        var river = new bool[X + 1];
        var cover = 0;   
        
        for(int i = 0; i < N; i++)
        {
            var V = A[i];
            if(river[V])
                continue;
            
            cover += V;
            river[V] = true;

            if(cover == reqCover)
                return i;
        }

        return -1;
    }

    public static void Test()
    {
        var X = 4;
        var A = new int[] {1, 2, 3, 4, 2, 3};
        var R = new FrogRiverOne().Solution(X, A);
        Console.WriteLine("Result: " + R);

        X = 4;
        A = new int[] {1, 4, 1, 2, 3, 4, 2, 3};
        R = new FrogRiverOne().Solution(X, A);
        Console.WriteLine("Result: " + R);

        X = 4;
        A = new int[] {1, 2, 1, 2, 3, 3, 2, 3};
        R = new FrogRiverOne().Solution(X, A);
        Console.WriteLine("Result: " + R);

        var N = new Random().Next(1, 100000);
        X = new Random().Next(1, 100000);
        A = CreateArray(N, 1, X);
        TestBuddy.PrintArray(A);
        Console.WriteLine("X: " + X);
        R = new FrogRiverOne().Solution(X, A);
        Console.WriteLine("result: " + R);
        var E = new FrogRiverOne().Check(X, A);
        Console.WriteLine("expected: " + E);

    }

    public int Check(int X, int[] A)
    {
        int position = A.Length;
        for(int i = 1; i <=X; i++)
        {
            int found = Array.IndexOf(A, i);
            if(found == -1)
                return -1;

            position = Math.Min(position, found);
        }

        return position;
    }
    public static int[] CreateArray(int N, int minValue, int maxValue)
    {
        var A = new int[N];
        var rand = new Random();
        for(int i = 0; i < N; i++)
        {
            A[i] = rand.Next(minValue, maxValue);
        }

        return A;
    }   
}}