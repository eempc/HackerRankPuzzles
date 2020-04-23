using System;
using System.Collections.Generic;
using System.Linq;
using HackerRank.Exercises;
using HackerRank.Misc;

namespace HackerRank {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            List<int> a = new List<int> { 3, 3, 3 };
            List<int> b = new List<int> { 1, 2, 3 };

            List<int> result = Warmups.CompareTheTriplets(a, b);
            foreach (var x in result) {
                Console.WriteLine(x);
            }

            Console.WriteLine("------ Factorial 5 test -------------");

            Console.WriteLine(Factorial(5));

            Console.WriteLine("------");

            long[] zzz = { 100000010, 100000020, 100000030, 100000040, 100000050 };
            Console.WriteLine(Warmups.AVeryBigSum(zzz));

            Console.WriteLine("-------- Sock Merchant ----------------");

            string[] sockArray = { "blue", "blue", "blue", "red", "red", "yellow", "yellow", "yellow", "yellow" };

            Console.WriteLine(Warmups.OddSocks(sockArray));

            Console.WriteLine("---------- AnagramPairs -------------");

            string test = "cdcd";
            for (int startIndex = 0; startIndex < test.Length; startIndex++) {
                for (int size = 1; size <= test.Length - startIndex; size++) {
                    string sub =  test.Substring(startIndex, size);
                    Console.WriteLine(sub);
                }
            }

            int counter = 3;
            int blah = 5;
            counter += blah++;

            Console.WriteLine(counter);

            Console.WriteLine("---------- Triplets -------------");

            List<long> testArr = new List<long> {
                1, 2, 2, 4, 2, 4, 8
            };

            Console.WriteLine(DictionariesHashMaps.Triplets(testArr, 2));

            Console.WriteLine("---------- Super reduced string -------------");

            Console.WriteLine(Strings.SuperReducedString("aaabccddd"));

            Console.WriteLine("----------Special String-------------");

            string specialStrigTest = "mnonopoo";

            for (int i = 0; i < specialStrigTest.Length; i++) {
                for (int size = 2; size < specialStrigTest.Length - i + 1; size++) {
                    string subString = specialStrigTest.Substring(i, size);
                    Console.WriteLine(subString);
                    Dictionary<char, int> dict = new Dictionary<char, int>();
                }
            }

            Console.WriteLine("-------Bubble------");

            Sorting.CountBubbleSortSwaps(new int[] { 5, 3, 1, 2 });

            Console.WriteLine("-------Luck Balance------");

            int[][] contests = new int[6][];
            contests[0] = new int[] { 5, 1 };
            contests[1] = new int[] { 2, 1 };
            contests[2] = new int[] { 1, 1 };
            contests[3] = new int[] { 8, 1 };
            contests[4] = new int[] { 10, 0 };
            contests[5] = new int[] { 5, 0 };

            List<int> importants = new List<int>();

            for (int i = 0; i < contests.Length; i++) {
                if (contests[i][1] == 1) {
                    importants.Add(contests[i][0]);
                } else {
                    //luck += contests[i][0];
                }
            }

            importants = importants.OrderByDescending(x => x).ToList();

            foreach (int x in importants) {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------Left Rotation----------------");

            int[] wah = { 1, 2, 3, 4, 5 };
           Warmups.LeftRotation2(5, 2, wah);

            Console.WriteLine("------Page Count-----");
            Console.WriteLine(Algorithms.pageCount(6, 2));
            Console.WriteLine("-----Excel Letters-----------");
            Console.WriteLine(Mathematics.ExcelLettersToNumber("AD"));
            Console.WriteLine(Mathematics.ExcelNumberToLetters(53));

            Console.WriteLine("----------------TreeNode--------------");
            Node six = new Node(6, null, null);
            Node four = new Node(4, null, null);
            Node three = new Node(3, null, four);
            Node five = new Node(5, three, six);
            Node two = new Node(2, null, five);
            Node one = new Node(1, null, two);

            Trees.Traversal(one);

            // Decoding from Morse to Latin letters

            Trees.MorseToLetters("-.- .. - - . -.");

            Trees.LevelOrderTraversal(one);
            Console.WriteLine("------------------------------");

            int aaa = 120;
            Console.WriteLine(aaa);
            int bbb = 80;
            aaa = aaa % bbb;
            aaa %= 30;

            Console.WriteLine(aaa);
            Console.WriteLine("--------------------------------");

            int[] movingTilesQueries = { 5, 1 };
            double[] movingTiles = Mathematics.movingTiles2(1000000, 1000004, 1000003, movingTilesQueries);
            foreach (double x in movingTiles) {
                Console.WriteLine(x);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine(Misc.Miscellaneous.ContainsDoubledDigits(1234));
            //Console.WriteLine(Misc.NumberOfDigits(1000,100000));
            int tt = 0;
            for (int i = 1000; i < 1100; i++) {
                if (Misc.Miscellaneous.IsAscendingDigits(i)) {
                    tt++;
                }
            }
            Console.WriteLine(tt);
            Console.WriteLine("------------------------------");
            int altitudeISS = 409000;
            Console.WriteLine(Orbital.GetVelocityOfCircularEarthOrbit(altitudeISS)); // ISS
            Console.WriteLine(Orbital.GetVelocityOfCircularEarthOrbit(35786000)); // Geostationary
            Console.WriteLine(Orbital.Circumference(Orbital.earthRadius + altitudeISS) / Orbital.GetVelocityOfCircularEarthOrbit(altitudeISS)); // Orbital period in seconds
        }



        



        // Helper methods

        public static int Factorial(int x) {
            if (x <= 1) return 1;
            else return x * Factorial(x-1);
        }

        public static int TriangleNumberRecursive(int x) {
            if (x <= 1) return 1;
            else return x + TriangleNumberRecursive(x - 1);
        }

        public static int TriangleNumberFormula(int x) {
            return x * (x + 1) / 2;
        }


    }
}
