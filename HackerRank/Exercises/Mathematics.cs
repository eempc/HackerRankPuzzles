using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Exercises {
    public class Mathematics {

        static int restaurant(int l, int b) {
            if (l == b) return 1;

            int greatestCommonDenominator = 0;

            for (int i = l; i >= 1; i--) {
                if (l % i == 0 && b % i == 0) {
                    greatestCommonDenominator = i;
                    break;
                }
            }

            return (l / greatestCommonDenominator) * (b / greatestCommonDenominator);

        }

        public static int summingSeries(long n) {
            long modulo = (long)Math.Pow(10, 9) + 7;
            long x = n % modulo;
            return (int)((x * x) % modulo);
        }


        public static int Summing(long n) {
            long total = 0;
            for (int i = 1; i <= n; i++) {
                total += ((i * i) - (i - 1) * (i - 1));
            }

            return (int)(total % (Math.Pow(10, 9) + 7));
        }

        static int Calculation(long x) {            
            return (int)((x * x) - (x - 1) * (x - 1));
        }

        static void BestDivisor(int n) {
            // Stage 1 - make a list to hold the divisors of n
            List<int> listOfDivisors = new List<int>();

            for (int i = 1; i <= Math.Sqrt(n); i++) { // The square root is just quicker but you could count to n if you wanted
                if (n % i == 0) { // If modulo i == 0 then it is a divisor
                    listOfDivisors.Add(i); // Add the left divisor
                    listOfDivisors.Add(n / i); // Add the right divisor (this is only needed if you use the square root above)
                }
            }

            // Stage 2
            // Store these two variables for the iteration
            int max = 0;
            int result = 0;

            // Then iterate the divisors, for each number add the sum of the digits
            foreach (int x in listOfDivisors) {
                int sumOfDigits = 0;
                int temp = x; // This temp is needed as we cannot modify x in the while loop

                // Use thise code to add the sum of the digits
                while (temp > 0) {
                    sumOfDigits += temp % 10;
                    temp /= 10;
                }

                // With our sum of digits, is it bigger than the old largest max?
                if (sumOfDigits > max) {
                    max = sumOfDigits;
                    result = x;
                } else if (sumOfDigits == max) { // But what if it is equal?
                    result = Math.Min(result, x);
                }
            }

            Console.WriteLine(result);

            // Single pass method?

            int maximumSum = 0;
            int theResult = 0;

            for (int i = 1; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) {
                    int sum = SumDigits(i);
                    if (sum > maximumSum) {
                        maximumSum = sum;
                        theResult = i;
                    } else if (sum == maximumSum) {
                        theResult = Math.Min(theResult, i);
                    }

                    sum = SumDigits(n / i);
                    if (sum > maximumSum) {
                        maximumSum = sum;
                        theResult = n / i;
                    } else if (sum == maximumSum) {
                        theResult = Math.Min(theResult, n / i);
                    }

                }
            }

            Console.WriteLine(theResult);
        }

        static int SumDigits(int x) {
            int sum = 0;
            while (x > 0) {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }

        public static string ExcelNumberToLetters(int x) {
            // Number to Letter is easier than the other way round
            // Don't forget to reverse the List
            //List<char> result = new List<char>();
            LinkedList<char> result = new LinkedList<char>();

            while (x > 0) {
                int value = x % 26;
                char c = NumberToLetter(value);
                result.AddFirst(c); // In JavaScript you would .shift to avoid having to reverse an array later
                x /= 26;
            }

            //result.Reverse(); 

            return new string(result.ToArray());
        }

        static char NumberToLetter(int x) {
            return (char)(x + 64);
        }

        public static int ExcelLettersToNumber(string str) {
            // In Excel we have letters to denote columns such as "AB"
            // Convert this to a decimal number, in this case, it is 28

            int total = 0;

            for (int i = 0; i < str.Length; i++) {
                // Take the last character and get its numerical value and multiply it by the base to the power of its position
                //int value = LetterToNumber(str[str.Length - 1 - i]) * (int)Math.Pow(26,i);
                int value = LetterToNumber(str[i]) * (int)Math.Pow(26, str.Length - 1 - i);
                total += value;
            }

            return total;
        }

        static int LetterToNumber(char c) {
            // character A begins at unicode 65
            return c - 64;
        }


        static long CuttingPaper(int n, int m) {
            return (long)m * (long)n - 1;

        }


        static int connectingTowns(int n, int[] routes) {
            // Multiplying every int in the array problem
            // Deal with very large numbers by using modulo
            int x = 1;
            for (int i = 0; i < routes.Length; i++) {
                x *= routes[i];
                x %= 1234567;
            }
            return x;

        }


        static int PrimeFactors(long n) {
            // Count the number of consecutive prime numbers up to a certain value where
            // if these primes are multiplied are less than the certain value
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

            for (int i = 3; i <= Math.Sqrt(x); i += 2) {
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
