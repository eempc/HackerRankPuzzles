﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Mathematics {

        static int PrimeFactors(long n) {
            if (n <= 1) return 0;
            if (n <= 3) return 1;

            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53 };

            int count = 0;
            long total = 1;

            for (int i = 0; i < primes.Length; i++) {
                if (i == 15) {
                    return count;
                }
                total *= primes[i];
                if (total <= n) {
                    count++;
                } else {
                    break;
                }
            }

            return count;
        }

        static bool IsPrimeStage0(int x) {
            if (x <= 1) return false;
            if (x <= 3 || x == 5 || x == 7) return true;

            // First pass is O(n)

            for (int i = 1; i < x; i++) {
                if (x % i == 0) return false;
            }

            return true;
        }


        static bool IsPrime(int x) {
            if (x <= 1) return false;
            if (x <= 3 || x == 5 || x == 7) return true;
            if (x % 2 == 0) return false;

            // Final pass is O(√n/4)

            for (int i = 3; i <= Math.Sqrt(x); i+=2) {                
                if (x % i == 0) return false;
            }

            return true;
        }


        static int gameWithCells(int n, int m) {
            if (n % 2 == 0) {
                n /= 2;
            } else {
                n = n / 2 + 1;
            }

            if (m % 2 == 0) {
                m /= 2;
            } else {
                m = m / 2 + 1;
            }

            return n * m;

        }

        static int Handshakes(int n) {
            // triangle numbers
            return (n * (n - 1)) / 2;
        }

        static int lowestTriangle(int b, int area) {
            double a = Convert.ToDouble(area);
            double w = Convert.ToDouble(b);
            return Convert.ToInt32(Math.Ceiling((2 * a) / w));
        }

        static int maximumDraws(int n) {
            /*
             * Write your code here.
             */
            return n + 1;
        }

        static int[] findPoint(int px, int py, int qx, int qy) {
            // Three points in a straight line:
            // 1: Start = 0, 0
            // 2: Mid = 3, 3
            // 3: Reflection = 6, 6
            int[] result = new int[2];

            result[0] = qx - px + qx; // Simplified to (2 * qx - px)
            result[1] = qy - py + qy;

            return result;
        }

    }
}
