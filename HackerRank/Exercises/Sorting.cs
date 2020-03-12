using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Exercises {
    class Sorting {

        public static int Comparator(Player a, Player b) {
            if (a.Score > b.Score) {
                return -1;
            } else if (a.Score < b.Score) {
                return 1;
            } else {
                return string.Compare(a.Name, b.Name);
            }
        }

        public class Player {
            public string Name { get; set; }
            public int Score { get; set; }
        }


        public static int MarkAndToys(int[] prices, int k) {
            int count = 0;
            int total = 0;

            Array.Sort(prices);

            foreach (int x in prices) {
                total += x;
                if (total > k) break;
                count++;
            }

            return count;
        }

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
