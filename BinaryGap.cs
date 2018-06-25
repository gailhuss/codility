using System;

namespace codility
{
    class BinaryGap { 
        public static void Test()
        {
            Console.WriteLine("==================");
            Console.WriteLine("Binary Gap Example");
            var n = new System.Random().Next(2000);

            Console.WriteLine("Number: " + n);
            Console.WriteLine("Binary: " + Convert.ToString(n, 2));
            Console.WriteLine("BinaryGap: " + new BinaryGap().Solution(n));
        }

        public int Solution(int N)
        {
            // Example:
            // 1041 
            // 10000010001 
            int max = 0;
            int gap = 0;
            bool isLastOdd = false;

            while(N > 0)
            {
                // ODD number
                if(N % 2 == 1)
                {
                    if(!isLastOdd)
                        max = max > gap ? max : gap;

                    isLastOdd = true;
                    gap = 0;
                }
                // Even number
                else
                {
                    if(isLastOdd || gap > 0)
                        gap ++;
                    isLastOdd = false;
                }
                
                N = N / 2;
            }

            return max;
        } 
    }
}