using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    public class Strings {

        public static int AlternatingCharacters(string s) {
            List<char> list = new List<char>();
            list.Add(s[0]);

            for (int i = 1; i < s.Length; i++) {
                if (s[i] != s[i-1]) {
                    list.Add(s[i]);
                }
            }

            return s.Length - list.Count;
        }


        public static int MakeAnagrams(string a, string b) {
            int count = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in a) {
                if (dict.ContainsKey(c)) {
                    dict[c]++;
                } else {
                    dict.Add(c, 1);
                }
            }

            foreach (char c in b) {
                if (dict.ContainsKey(c)) {
                    dict[c]--;
                } else {
                    dict.Add(c, -1);
                }
            }

            foreach (KeyValuePair<char, int> kvp in dict)
                count += Math.Abs(kvp.Value);

            return count;
        }

    }
}
