using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class NumberTheory {
        public static int FibonacciStuff(int a, int b, int n) {
            if (n == 1) return b;
            if (n == 2) return a + b;

            int answer = 0;
            int mod = (int)Math.Pow(10, 9) + 7;

            int[] array = new int[n + 1];
            array[0] = a;
            array[1] = b;

            for (int i = 2; i <= n; i++) {
                array[i] = array[i - 1] + array[i - 2];
                answer = array[i];
            }

            return answer % mod;
        }

        public static int SmithNumber(int n) {
            // Sum digits of given number n
            int sumDigits = SumDigits(n);

            int sumFactors = 0;

            // Divide by 2 if even number until we get odd number
            while (n % 2 == 0) {
                sumFactors += 2;
                n /= 2;
            }

            // Start looping i efficiently
            for (int i = 3; i <= Math.Sqrt(n); i += 2) {
                while (n % i == 0) {
                    // If divisible by i (a prime number)
                    sumFactors += SumDigits(i);
                    n /= i;
                    // NB numbers like 9 and 15 are preceded by 3
                }
            }

            // Final check for the last prime number, it could be 11 for example, which would sum to 2
            if (n > 2) {
                sumFactors += SumDigits(n);
            }

            return (sumDigits == sumFactors) ? 1 : 0;
        }

        public static int SumDigits(int x) {
            int total = 0;
            while (x > 0) {
                total += x % 10;
                x /= 10;
            }
            return total;
        }

    }



}
