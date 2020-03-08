using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Sorting {
        public static void CountBubbleSortSwaps(int[] a) {
            int count = 0;

            for (int i = 0; i < a.Length; i++) {
                for (int j = 0; j < a.Length - 1; j++) {
                    if (a[j] > a[j + 1]) {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        count++;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {count} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Length - 1]}");
        }
        

    }
}
