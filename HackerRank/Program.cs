using System;
using System.Collections.Generic;

namespace HackerRank {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            List<int> a = new List<int> { 3, 3, 3 };
            List<int> b = new List<int> { 1, 2, 3 };

            List<int> result = CompareTheTriplets(a, b);
            foreach (var x in result) {
                Console.WriteLine(x);
            }

            Console.WriteLine("------");

            Console.WriteLine(Factorial(5));

            Console.WriteLine("------");

            long[] zzz = { 100000010, 100000020, 100000030, 100000040, 100000050 };
            Console.WriteLine(AVeryBigSum(zzz));
        }

        // https://www.hackerrank.com/challenges/compare-the-triplets/problem
        public static List<int> CompareTheTriplets(List<int> a, List<int> b) {
            List<int> result = new List<int> { 0, 0 };

            for (int i = 0; i < a.Count; i++) {
                if (a[i] == b[i]) continue;
                if (a[i] > b[i]) result[0]++;
                else result[1]++;
            }

            return result;
        }

        // Add the ints in an array bearing in mind the pattern of the array
        // https://www.hackerrank.com/challenges/a-very-big-sum/problem?h_r=next-challenge&h_v=zen

        public static long AVeryBigSum(long[] ar) {
            // Brute Force Solution
            long result = 0;
            foreach (long x in ar) {
                result += x;
            }
            return result;

            // A more sophisticated?

            //int n = ar.Length;
            //long difference = ar[1] - ar[0];
            //long result = n * ar[0] + TriangleNumber(n - 1) * difference;
            //return result;
        }

        public static int Factorial(int x) {
            if (x <= 1) return 1;
            else return x * Factorial(x-1);
        }

        public static int TriangleNumberRecursive(int x) {
            if (x <= 1) return 1;
            else return x + TriangleNumberRecursive(x - 1);
        }

        public static int TriangleNumberFormula(int x) {
            return x * (x + 1) / 2;
        }
    }
}
