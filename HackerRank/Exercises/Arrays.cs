using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Arrays {
        // New Year Chaos - could try a bubble sort or start backwards
        public static void MinimumBribes(int[] queue) {
            bool chaotic = false;
            int count = 0;

            for (int i = 0; i < queue.Length - 1; i++) {
                if (queue[i] > i + 1 || queue[i] > queue[i+1]) {
                    if (queue[i] > i + 3) {
                        chaotic = true;
                        break;
                    }
                    
                    if (queue[i] == i + 3) {
                        count += 2;
                    } else {  
                        count += 1;
                    }
                }
            }

            if (chaotic) {
                Console.WriteLine("Too chaotic");
            } else {
                Console.WriteLine(count);
            }
        }

        // Hourglass array shape
        public static int HourGlassSum(int[][] arr) {
            int x = -25000;
            for (int i = 0; i < arr.Length - 2; i++) {
                for (int j = 0; j < arr.Length - 2; j++) {
                    // Add up all the elements in the hourglass shape
                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                                          arr[i + 1][j + 1] +
                              arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (sum > x) {
                        x = sum;
                    }
                }
            }

            return x;
        }
    }
}
