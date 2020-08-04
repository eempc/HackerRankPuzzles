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
    }
}
