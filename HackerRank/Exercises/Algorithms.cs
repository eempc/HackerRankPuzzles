using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Exercises {
    class Algorithms {

        public static int pickingNumbers(List<int> a) {
            a.Sort();

            int best = 0;
            int temp = 0;

            for (int i = 0; i < a.Count(); i++) {
                temp = 1;
                if (i > 0 && a[i] == a[i-1]) {
                    continue;
                }

                for (int j = i + 1; j < a.Count(); j++) {
                    if (a[j] - a[i] <= 1) {
                        temp++;
                    } else {
                        break;
                    }
                }
                if (temp > best) {
                    best = temp;
                }
            }

            return best;
        }





        public static int pageCount(int n, int p) {


            Console.WriteLine(Math.Min(p / 2, (n + 1 - p) / 2));
            Console.WriteLine(Math.Min(p / 2, n / 2 - p / 2));

            if (p <= n / 2) {
                return p / 2;
            } else {
                return (n + 1 - p) / 2;
            }

            
        }

        static void bonAppetit(List<int> bill, int k, int b) {
            int share = (bill.Sum() - bill[k]) / 2;
            if (share == b) {
                Console.WriteLine("Bon Appetit");
            } else {
                Console.WriteLine(b - share);
            }

        }

        static int BirthdayChocolate(List<int> s, int d, int m) {
            int count = 0;

            for (int i = 0; i < s.Count() - m + 1; i++) {
                int x = 0;
                for (int j = i; j < i + m; j++) {
                    x += s[j];
                }
                if (x == d) count++;
            }

            return count;
        }

        static int BirthdayChocolateLinq(List<int> s, int d, int m) {
            int count = 0;

            for (int i = 0; i < s.Count() - m + 1; i++) {
                int x = s.Skip(i).Take(m).Sum();
                if (x == d) count++;
            }

            return count;
        }

        static int[] breakingRecords(int[] scores) {
            int[] result = new int[2];

            int max = scores[0];
            int min = scores[0];

            foreach (int x in scores) {
                if (x > max) {
                    result[0]++;
                    max = x;
                } else if (x < min) {
                    result[1]++;
                    min = x;
                }
            }

            return result;
        }


        static string kangaroo(int x1, int v1, int x2, int v2) {
            int jumpDistance = v2 - v1; // 3 and 5 = 2 - which way round doesn't matter
            int distanceDelta = x1 - x2; // 0 and 6 = -6
            bool canCatchUp = v2 < v1; // Firstly determine if k1 can catch up with k2 given that k2 always starts ahead

            // next use straight line equations 2x + 1 and 1x + 2 as examples where x is number of jumps
            // Subtract them according to the above formulas oppositely
            // Determine if the modulo is 0

            if (canCatchUp && distanceDelta % jumpDistance == 0) {
                return "YES";
            }

            return "NO";
        }


        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
            int countApples = 0;
            int countOranges = 0;

            for (int i = 0; i < apples.Length; i++) {
                if (apples[i] + a >= s && apples[i] + a <= t) {
                    countApples++;
                }
            }

            foreach (int x in oranges) {
                if (x + b <= t && x + b >= s) {
                    countOranges++;
                }
            }

            Console.WriteLine(countApples);
            Console.WriteLine(countOranges);
        }

        static void CountApplesAndOrangesLinq(int s, int t, int a, int b, int[] apples, int[] oranges) {
            int countApples = apples.Count(x => x + a >= s && x + a <= t);
            int countOranges = oranges.Count(x => x + b <= t && x + b >= s);

            Console.WriteLine(countApples);
            Console.WriteLine(countOranges);
        }

        static List<int> GradingStudents(List<int> grades) {
            List<int> result = new List<int>();

            foreach (int x in grades) {
                if (x < 38) {
                    result.Add(x);
                } else if (x % 5 > 2) {
                    result.Add(x + 5 - (x % 5));
                } else {
                    result.Add(x);
                }
            }

            return result;
        }

    }
}
