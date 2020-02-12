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

            Console.WriteLine("------ Factorial 5 test -------------");

            Console.WriteLine(Factorial(5));

            Console.WriteLine("------");

            long[] zzz = { 100000010, 100000020, 100000030, 100000040, 100000050 };
            Console.WriteLine(AVeryBigSum(zzz));

            Console.WriteLine("-------- Sock Merchant ----------------");

            string[] sockArray = { "blue", "blue", "blue", "red", "red", "yellow", "yellow", "yellow", "yellow" };

            Console.WriteLine(OddSocks(sockArray));
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

        // https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        public static int OddSocks(string[] ar) {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            int totalPairs = 0;

            foreach (string x in ar) {
                if (inventory.ContainsKey(x)) inventory[x]++; // ContainsKey is an O(1) operation
                else inventory.Add(x, 1);

                if (inventory[x] % 2 == 0) totalPairs++; // Instead of the additional iteration below, do the check for pairs here
            }
         
            // Using this additional iteration was O(n) + O(m)
            //foreach (KeyValuePair<int, int> entry in inventory) {
            //    total += entry.Value / 2;
            //}

            return totalPairs;
        }



        // Helper methods

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
