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
    }
}
