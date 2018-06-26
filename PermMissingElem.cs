using System;

class PermMissingElem {
    public int Solution(int[] A) {
        var N = A.Length;
        var sum = 0;
        var expected = 0;
        for(int i = 0; i < N; i++) {
            expected += i + 1;
            sum += A[i];
        }
        
        expected += N + 1;
        
        return expected - sum;
    }
}