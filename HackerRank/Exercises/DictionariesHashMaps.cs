using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class DictionariesHashMaps {

        public static int AnagramPairs(string s = "ifailuhkqq") {
            int count = 0;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int startIndex = 0; startIndex < s.Length; startIndex++) {
                for (int size = 1; size <= s.Length - startIndex; size++) {
                    string sub = Alphabetise(s.Substring(startIndex, size));
                    if (!dict.ContainsKey(sub)) {
                        dict.Add(sub, 1);
                    } else {
                        dict[sub]++;
                    }
                }
            }

            foreach (KeyValuePair<string, int> kvp in dict) {
                count += (kvp.Value * (kvp.Value - 1)) / 2;
            }

            return count;
        }

        public static string Alphabetise(string s) {
            char[] a = s.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }


        public static string TwoStrings(string s1, string s2) {
            // The trick is in the sentence, "one character"
            string possible = "NO";

            foreach (char c in s1) {
                if (s2.Contains(c.ToString())) {
                    possible = "YES";
                    break;
                }
            }

            return possible;
        }

        public static string TwoStrings2(string s1, string s2) {
            string possible = "NO";

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (char c in s1) {
                if (!dict.ContainsKey(c.ToString())) {
                    dict.Add(c.ToString(), 1);
                }
            }

            foreach (char c in s2) {
                if (dict.ContainsKey(c.ToString())) {
                    possible = "YES";
                    break;
                }
            }

            return possible;
        }



        public static void checkMagazine(string[] magazine, string[] note) {
            string possible = "Yes";

            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            foreach (string word in magazine) {
                if (wordFrequency.ContainsKey(word)) {
                    wordFrequency[word]++;
                } else {
                    wordFrequency.Add(word, 1);
                }
            }

            foreach (string word in note) {
                if (wordFrequency.ContainsKey(word)) {
                    wordFrequency[word]--;
                    if (wordFrequency[word] < 0) {
                        possible = "No";
                        break;
                    }
                } else {
                    possible = "No";
                    break;
                }
            }

            Console.WriteLine(possible);
        }
    }
}
