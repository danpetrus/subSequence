using System;

namespace SubSequenceArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 5, 1, 22, 25, 6, -1, 8, 10 };
            int[] B = { 1, 6, -1, 10 };
            int x = 0;
            bool match = false;

            foreach (int i in B)
            {
                match = false;

                while (x < A.Length)
                {
                    Console.WriteLine("Comparing " + i + " with " + A[x] + " | ");
                    if (i == A[x])
                    {
                        x++;
                        match = true;
                        break;
                    }
                    x++;
                }
            }

            if (match == false)
            {
                Console.WriteLine("");
                Console.WriteLine("B IS NOT Subsequence of A");
            }
            else 
            {
                Console.WriteLine("");
                Console.WriteLine("B IS Subsequence of A");
            }
        }
    }
}
