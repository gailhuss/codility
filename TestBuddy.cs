using System;
using System.Linq;

namespace codility {
    public class TestBuddy {
        public static void PrintArray(int[] A)
        {
            Console.WriteLine("[" + A.Select(i => i.ToString()).Aggregate((a, b) => a + ", " + b) + "]");
        }

        public static void PrintTestResult(int expected, int result)
        {
            Console.WriteLine(expected + " : " + result);
        }
    }
}