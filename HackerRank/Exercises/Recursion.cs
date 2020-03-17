using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Recursion {
        static int Fibonacci(int n) {
            if (n <= 1) return n;
            if (n == 2) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int SuperDigit(string n, int k) {
            if (n.Length == 1) {
                return n[0] - '0';
            }

            int sum = 0;
            for (int i = 0; i < n.Length; i++) {
                sum += n[i] - '0';
            }
            sum *= k;

            return SuperDigit(sum.ToString(), 1);

        }

        static int DigitSum(string n, int k) {
            int result = 0;
            foreach (char c in n) {
                result += c - '0';
            }

            result *= k;

            return DigitSumHelper(result);
        }

        static int DigitSumHelper(int x) {
            if (x < 10) {
                return x;
            }

            return DigitSumHelper(DigitSumAdder(x));
        }

        static int DigitSumAdder(int x) {
            if (x == 0) {
                return 0;
            }

            return x % 10 + DigitSumAdder(x / 10);
        }

    }
}
