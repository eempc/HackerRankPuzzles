using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    public class Strings {

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

            foreach (KeyValuePair<char, int> kvp in dict) {
                if (kvp.Value < 0) {
                    count -= kvp.Value;
                } else {
                    count += kvp.Value;
                }
            }

            return count;
        }

    }
}
