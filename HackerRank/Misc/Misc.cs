using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Random {
    class Misc {
        // Does this int contains a double number e.g. 11234
        public static bool ContainsDoubledDigits(int x) {
            // Starting from right to left
            while (x > 0) {
                int currentMod = x % 10;
                int nextNumber = x / 10;
                int nextMod = nextNumber % 10;
                if (currentMod == nextMod) {
                    return true;
                }
                x /= 10;
            }
            return false;
        }

        // Is this number's digits in ascending order? Doublers allowed
        public static bool IsAscendingDigits(int x) {
            while (x > 0) {
                int currentMod = x % 10;
                int nextNumber = x / 10;
                int nextMod = nextNumber % 10;
                if (currentMod < nextMod) {
                    return false;
                }
                x /= 10;
            }
            return true;
        }

        public static int NumberOfDigits(int start = 0, int end = 1000000) {
            int total = 0;

            for (int i = start; i <= end; i++) {
                if (IsAscendingDigits(i) && ContainsDoubledDigits(i)) {
                    total++;
                    Console.WriteLine(i);
                }
            }

            return total;
        }


    }
}
