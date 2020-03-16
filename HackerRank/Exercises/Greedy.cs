using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Exercises {
    class Greedy {



        static int LuckBalance(int k, int[][] contests) {
            int luck = 0;

            List<int> importants = new List<int>();

            for (int i = 0; i < contests.Length; i++) {
                if (contests[i][1] == 1) {
                    importants.Add(contests[i][0]);
                } else {
                    luck += contests[i][0];
                }
            }

            importants = importants.OrderByDescending(x => x).ToList();

            for (int i = 0; i < importants.Count; i++) {
                if (i < k) luck += importants[i];
                else luck -= importants[i];
            }

            return luck;
        }

        static int MinAbsDiffArr2(int[] arr) {
            Array.Sort(arr);

            int min = Math.Abs(arr[0] - arr[1]);

            for (int i = 0; i < arr.Length - 1; i++) {
                int x = Math.Abs(arr[i] - arr[i + 1]);
                if (x < min) min = x;
            }

            return min;
        }

        static int MinAbsDiffArr(int[] arr) {
            int result = Math.Abs(arr[0] - arr[1]);

            for (int i = 0; i < arr.Length; i++) {
                for (int j = i + 1; j < arr.Length; j++) {
                    int x = Math.Abs(arr[i] - arr[j]);
                    if (x < result) {
                        result = x;
                    }

                }
            }

            return result;
        }

    }
}
