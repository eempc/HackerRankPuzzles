using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO.Pipes;
using System.Numerics;

namespace HackerRank.Exercises {
    public class Mathematics {

        // Starting at coordinates (a,b), you can change your horizontal coordinate by "b" units
        // and the vertical coordinate by "a" units. If your destination is (x, y), can you get there
        // Again this is a GCD problem utilising Euclidean
        // Know the formula (fast) or don't know the formula (slow)
        static string solve(long a, long b, long x, long y) {
            if (Euclidean(a, b) == Euclidean(x, y)) {
                return "YES";
            }

            return "NO";
        }



        // Russian Peasant Exponentiation
        // (a + b * i) ^ k = c + d * i
        // Return c % m and d % m
        static int[] ComplexPowersOne (int a, int b, long k, int m) {
            // Does not handle negatives
            a %= m;
            b = b % m;
            Complex ab = new Complex(a, b);
            Complex cd = Complex.Pow(ab, k);
            int real = (int)cd.Real;
            int imaginary = (int)cd.Imaginary;
            return new int[] { real % m, imaginary % m };
        }

        // Recursive method
        static void ComplexPowersTwo (int a, int b, long k, int m) {

            
        }



        public static long HalloweenChocolateCuts(int k) {
            long x = (long)k;
            if (x % 2 == 0) {
                return (x / 2) * (x / 2);
            }

            return (x / 2) * ((x / 2) + 1);
        } 




        // Given 16 pool balls all lined up, how many combinations of different lineups are possible?
        // The answer is 16!, permutations without repetition
        // If you only want 3 balls, then it is the first three factorials i.e. 16 * 15 * 14

        // Permutations witout repetition involves factorial
        // Given a string e.g. "000011", with 4 zeroes and 2 ones, how many permutations is that?
        // How many permutations begin with 1
        // The formula has been reduced to (n+m+1) / (m-1)! * n!


        // Permuations with Repetition
        static int HowManyPermutations(int characterBase = 26, int passwordLength = 8) {          
            return (int)Math.Pow(characterBase, passwordLength);
        }

        // It's very interesting to see this different approach, sum up the digits and divide that by 3
        // Obviously not doing the n % 3 == 0 check
        // Sum digits % 3 == 0 crazy

        static void EulersCriterion(int a, int m) {
            // An equation a = X^2 % prime (m); determine x 
            // Is not as simple as taking the square root of a to find x
            // It is about integers, so no floats


        }

        long modpow(long base_value, long exponent, long modulus) {
            base_value = base_value % modulus;
            long result = 1;
            while (exponent > 0) {
                if (exponent % 2 == 1) result = (result * base_value) % modulus;
                base_value = (base_value * base_value) % modulus;
                exponent = exponent / 2;
            }
            return result;
        }

        //  What is the number of divisors of n that are divisible by 2?.
        public static int SherlockDivisors(int n) {
            if (n % 2 == 1) return 0; // Odd numbers can never have even divisors
            if (n == 2) return 1;

            double root = Math.Sqrt(n);

            int total = 0;

            for (int i = 1; i <= (int)root; i++) {
                if (n % i == 0) { // Check if it is a divisor
                    if (i % 2 == 0) {
                        total++; // Check if left factor is even
                    }
                    if (n / i % 2 == 0 && i != n / i) { // Check if right factor is even && is also not the same as right factor (perfect square)
                        total++;
                    }
                }
            }

            return total;          
        }


        public static void FibonacciProperties() {
            // Fibonacci(0) = 0
            // Maximum uint = 2^31 - 1 = 2.15 billion = 2,147,483,648 - 1 = 2.15 * 10^9
            // Maximum int = +/- 2^32 - 1 = 4.3 billion = 4,294,967,296 - 1 = 4.3 * 10^9
            // Maximum ulong = 2^64 - 1 = 18.4 sextillion = ‭18,446,744,073,709,551,616‬ - 1 = 18.4 E 18
            // Maximum long = +/- 2^63 - 1 = 9.2 sextillion = ‭9,223,372,036,854,775,808‬ - 1 = 9.2 * 10^18
            // Fibonacci(46) = ‭1,836,311,903‬ = 1.8 billion
            // Fibonacci(47) ‭= 2,971,215,073‬ = 3 billion
            // Fibonacci(92) = ‭7,540,113,804,746,346,429‬ = 7.5 sextillion
            // Fibonacci(93) = ‭12,200,160,415,121,876,738‬ = 12 sextillion 

        }

        // Naive way to determine if a number is fibonacci
        public static bool IsFibonacci(int n) {
            bool result = false;
            int sum = 0;
            int first = 0;
            int second = 1;

            while (sum < n) {
                sum = first + second;
                if (sum == n) {
                    return true;
                }

                first = second;
                second = sum;
            }

            return result;
        }

        public static int BinetFormula(int n) {
            double root5 = Math.Sqrt(5);
            return (int)((1 / root5) *  (Math.Pow((1 + root5) / 2, n) - Math.Pow((1 - root5) / 2, n)));
        }


        public static void FibonacciForLoop(int limit = 10) {
            int first = 0;
            int second = 1;
            for (int i = 0; i < limit; i++) {
                int sum = first + second;
                first = second;
                second = sum;
                Console.WriteLine(sum);
            }

        }

        public static void FibonacciWhileLoop(int limit = 10) {
            int first = 0;
            int second = 1;
            int sum = 0;

            int counter = 0;

            while (counter < limit) {
                sum = first + second;
                first = second;
                second = sum;
                Console.WriteLine(sum);
                counter++;
            }

        }


        public static int FillingJars(int n, int[][] operations) {
            int total = 0;

            foreach (int[] op in operations) {
                total += (op[1] - op[0] + 1) * op[2];
            }

            return total / n;
        }



        public static double[] movingTiles2(int l, int s1, int s2, int[] queries) {
            double[] results = new double[queries.Length];
            int relativeDiagonalVelocity = Math.Abs(s2 - s1);

            for (int i = 0; i < queries.Length; i++) {
                double areaOfQ = queries[i];
                double lengthOfQ = Math.Sqrt(areaOfQ);
                double diagonalOfQ = Math.Sqrt(2) * lengthOfQ;

                double diagonalOfL = Math.Sqrt(2) * l;

                double travelDistance = diagonalOfL - diagonalOfQ;

                // V = d * t => t = d / V
                double time = travelDistance / relativeDiagonalVelocity;
                results[i] = time;

            }

            return results;
        }


        static double[] movingTiles(int l, int s1, int s2, int[] queries) {
            double[] results = new double[queries.Length];
            long relativeDiagonalVelocity = Math.Abs(s2 - s1); 

            for (int i = 0; i < queries.Length; i++) {
                double targetRelativeHorizontalLength = l - Math.Sqrt(queries[i]);
                double targetRelativeDiagonalLength = Math.Sqrt(2) * targetRelativeHorizontalLength; // Or use Pythagoras for the long version
                double time = targetRelativeDiagonalLength / relativeDiagonalVelocity;
                results[i] = time;
            }

            return results;
        }

        static int restaurant(int l, int b) {
            int largestCommonDivisor = 0;

            for (int i = l; i >= 1; i--) {
                if (l % i == 0 && b % i == 0) {
                    largestCommonDivisor = i;
                    break;
                }
            }

            return (l / largestCommonDivisor) * (b / largestCommonDivisor);

        }


        // Euclidean Algorithm to find the GCD
        static long Euclidean(long a, long b) {
            while (a != 0 && b != 0) {
                if (a > b) {
                    a %= b;
                } else {
                    b %= a;
                }
            }

            return (a == 0) ? b : a;
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

        //  This was an arbitrator problem of what someone's criteria of "best divisor" was
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

        // Add the individual digits to return a value of their sum
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
