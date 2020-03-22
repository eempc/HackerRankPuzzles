using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Algorithms {

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
