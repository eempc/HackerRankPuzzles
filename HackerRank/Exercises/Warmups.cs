using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Exercises {
    public class Warmups {
        public static void LeftRotation(int n, int d, int[] a) {
            int[] x = new int[n];
            for (int i = 0; i < n; i++) {
                int index = (n - d + i) % n;
                x[index] = a[i];
            }
            foreach (int y in x) {
                Console.Write(y);
                Console.Write(" ");
            }
        }

        public static void LeftRotation2(int n, int d, int[] a) {
            

        }

        static int[] ReverseArray(int[] a) {
            int[] x = new int[a.Length];
            for (int i = 0; i < a.Length; i++) {
                x[x.Length - i - 1] = a[i];
            }
            return x;
        }


        static string TimeConversion(string s) {
            char[] arr = s.ToCharArray();

            if (arr[8] == 'A') {
                if (arr[0] == '1' && arr[1] == '2') {
                    arr[0] = '0';
                    arr[1] = '0';
                }
                return new string(arr).Substring(0,8);
            }

            if (arr[0] == '1' && arr[1] == '2') {
                return new string(arr).Substring(0, 8);
            }

            arr[0]++;

            arr[1]++;
            arr[1]++;

            return new string(arr).Substring(0, 8);

        }




        static int BirthdayCakeCandles(int[] ar) {
            int count = 0;
            int largest = 0;
            
            for (int i = 0; i < ar.Length; i++) {
                if (ar[i] > largest) {
                    largest = ar[i];
                    count = 0;
                } 
                
                if (ar[i] == largest) {
                    count++;
                }
            }

            return count;
        }

        static int BirthdayCakeCandles2(int[] ar) {
            return ar.Count(x => x == ar.Max());
        }


        static void MinMax(int[] arr) {
            Array.Sort(arr); // O(n log n)

            long max = 0;
            long min = 0;

            // O(n)
            for (int i = 0; i < 4; i++) {
                min += arr[i];
                max += arr[arr.Length - 1 - i];
            }

            Console.WriteLine(min + " " + max);

        }

        static void MinMax2(int[] arr) {
            // O(n) solution
            long sum = 0;
            long max = 0;
            long min = Int64.MaxValue;

            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            long resultSmallest = sum - max;
            long resultBiggest = sum - min;

            Console.WriteLine(resultSmallest + " " + resultBiggest);

        }

        static void StairCase2(int n) {
            for (int i = 0; i < n; i++) {
                string str = new string('#', i + 1).PadLeft(n, ' ');
                Console.WriteLine(str);
            }
        }

        static void StairCase(int n) {
            for (int i = 1; i <= n; i++) {
                for (int j = n - i; j > 0; j--) {
                    Console.Write(" ");
                    if (j == 0) Console.Write("\r\n");
                }
                
                for (int k = 0; k < i; k++) {
                    Console.Write("#");
                    if (k == i - 1) Console.Write("\r\n");
                }
                
            }
        }

        static void PlusMinus(int[] arr) {
            double n = Convert.ToDouble(arr.Length);

            int positives = 0;
            int negatives = 0;
            int zeroes = 0;

            foreach (int x in arr) {
                if (x > 0) positives++;
                else if (x < 0) negatives++;
                else zeroes++;
            }

            double positiveRatio = positives / n;
            double negativeRatio = negatives / n;
            double zeroRatio = zeroes / n;

            Console.WriteLine(positiveRatio);
            Console.WriteLine(negativeRatio);
            Console.WriteLine(zeroRatio);
        }

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
