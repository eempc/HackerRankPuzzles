using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Exercises {
    public class Warmups {

        public static int DiagonalDifference(List<List<int>> arr) {
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int n = arr.Count;

            for (int i = 0; i < n; i++) {
                primaryDiagonal += arr[i][i];
                secondaryDiagonal += arr[i][n - i - 1];
            }

            return Math.Abs(primaryDiagonal - secondaryDiagonal);
        }

        public static int CloudJump(int[] c) {
            int count = 0;

            for (int i = 0; i < c.Length - 1; i++) {
                if (c[i+2] == 0 && i < c.Length - 2) {
                    count++;
                    i++;
                } else {
                    count++;
                }
            }

            return count;
        }


        public static long RepeatedString(long n, string s) {
            long length = s.Length;
            long repeats = n / length;

            long count = 0;

            // The following is replaced by LINQ's s.Count(ch => ch = 'a')
            foreach (char c in s) {
                if (c == 'a') count++;
            }

            count *= repeats;

            // The following is replaced by LINQ's finalSubstring.Count(ch => ch == 'a')
            long substringIndex = n % length;
            string finalSubstring = s.Substring(0, (int)substringIndex);

            foreach (char c in finalSubstring) {
                if (c == 'a') count++;
            }

            return count;
        }

        public static long RepeatedStringLinq(long n, string s) {
            long count = n / s.Length * s.Count(ch => ch == 'a');
            count += (s.Substring(0, (int)(n % s.Length))).Count(ch => ch == 'a');
            return count;
        }


        public static int CountValleys(string s) {
            int count = 0;
            int level = 0;
            foreach (char c in s) {
                if (c == 'D') level--;
                if (c == 'U') level++;

                if (c == 'U' && level == 0) {
                    count++;
                }
            }

            return count;
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

    }
}
