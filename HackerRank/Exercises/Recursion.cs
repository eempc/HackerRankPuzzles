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


    }
}
