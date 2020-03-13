using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Greedy {

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
