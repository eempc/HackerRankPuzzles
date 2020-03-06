using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class DictionariesHashMaps {



        // This works but times out
        public static List<int> FrequencyQueries(List<List<int>> queries) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (List<int> query in queries) {
                switch (query[0]) {
                    case 1:
                        if (dict.ContainsKey(query[1])) {
                            dict[query[1]]++;
                        } else {
                            dict.Add(query[1], 1);
                        }
                        break;
                    case 2:
                        if (dict.ContainsKey(query[1]) && dict[query[1]] > 0) {
                            dict[query[1]]--;
                        }
                        break;
                    case 3:
                        if (dict.ContainsValue(query[1])) {
                            result.Add(1);
                        } else {
                            result.Add(0);
                        }
                        break;
                }
            }

            return result;
        }

        public static int Triplets(List<long> arr, long r) {
            // Failed this one
            int count = 0;
            Dictionary<long, int> leftDict = new Dictionary<long, int>();
            Dictionary<long, int> rightDict = new Dictionary<long, int>();

            leftDict.Add(arr[0], 1);
            //leftDict.Add(arr[1], 0);

            for (int i = 2; i < arr.Count; i++) {
                if (!rightDict.ContainsKey(arr[i])) {     
                    rightDict.Add(arr[i], 1);
                } else {
                    rightDict[arr[i]]++;
                }
            }

            for (int j = 1; j < arr.Count - 1; j++) {
                if (leftDict.ContainsKey(arr[j] / r) && leftDict[arr[j] / r] > 0 && arr[j] % r == 0  
                    && rightDict.ContainsKey(arr[j] * r) && rightDict[arr[j] * r] > 0) {
                    count += leftDict[arr[j] / r] * rightDict[arr[j] * r];
                }

                if (leftDict.ContainsKey(arr[j])) {
                    leftDict[arr[j]]++;
                } else {
                    leftDict.Add(arr[j], 1);
                }

                rightDict[arr[j + 1]]--;
            }

            return count;
        }


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

        public static int AnagramPairs2(string s = "ifailuhkqq") {
            int count = 0;
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int startIndex = 0; startIndex < s.Length; startIndex++) {
                for (int size = 1; size <= s.Length - startIndex; size++) {
                    string sub = Alphabetise(s.Substring(startIndex, size));
                    if (!dict.ContainsKey(sub)) {
                        dict.Add(sub, 1);
                    } else {
                        count += dict[sub]++;
                    }
                }
            }

            //foreach (KeyValuePair<string, int> kvp in dict) {
            //    count += (kvp.Value * (kvp.Value - 1)) / 2;
            //}

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
