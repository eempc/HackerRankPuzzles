using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Exercises {
    class Arrays {

        public static string TwoArrays(int k , int[] A, int[] B) {
            Array.Sort(A);
            B = B.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < A.Length; i++) {
                if (A[i] + B[i] < k) {
                    return "NO";
                }
            }

            return "YES";
        }



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

        public static int[] LeftRotation(int[] a, int d) {
            return a.Skip(d).Concat(a.Take(d)).ToArray();
        }

        public static int[] LeftRotation2(int[] a, int d) {
            int[] x = a.Take(d).ToArray(); // Take the first d elements
            int[] y = a.Skip(d).ToArray(); // Remove the first d elements
            return y.Concat(x).ToArray();
        }

        public static int MinimumSwaps(int[] arr) {
            int swaps = 0;

            for (int i = 0; i < arr.Length; i++) {
                // Look for the first misplaced integer
                if (arr[i] != i + 1) {
                    int t = i;

                    // This while loop looks for the correct integer and notes the index as t
                    while(arr[t] != i + 1) {
                        t++;
                    }

                    // Then do the standard switcheroo
                    int temp = arr[t];
                    arr[t] = arr[i];
                    arr[i] = temp;
                    swaps++;
                }
            }

            return swaps;

        }

    }
}
