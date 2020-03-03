using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    public class Strings {

        

        public static int StrongPassword0(string password) {
            int count = 0;

            bool containsDigit = false;
            bool containsLower = false;
            bool containsUpper = false;
            bool containsSpecial = false;

            char[] specials = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };

            foreach (char c in password) {
                if (char.IsDigit(c)) {
                    containsDigit = true;
                }
                if (char.IsLower(c)) {
                    containsLower = true;
                }
                if (char.IsUpper(c)) {
                    containsUpper = true;
                }
                if (Array.Exists(specials, e => e == c)) {
                    containsSpecial = true;
                }
            }

            if (!containsDigit) {
                count++;
            }

            if (!containsLower) {
                count++;
            }

            if (!containsUpper) {
                count++;
            }

            if (!containsSpecial) {
                count++;
            }

            if (password.Length + count < 6) {
                count += 6 - password.Length - count;
            }

            return count;
        }
        
        public static int CamelCase(string s) {
            int count = 1;

            foreach (char c in s) {
                if (char.IsUpper(c)) {
                    count++;
                }
            }

            return count;
        }

        public static string SuperReducedString(string s) {           
            for (int i = 1; i < s.Length; i++) {
                if (s[i] == s[i-1]) {
                    s = s.Substring(0, i - 1) + s.Substring(i + 1);
                    i = 0;
                }
            }

            if (s.Length == 0) {
                return "Empty String";
            }

            return s;
        }

        public static string SherlockValidString(string s) {
            Dictionary<char, int> charDict = new Dictionary<char, int>();

            foreach (char c in s) {
                if (charDict.ContainsKey(c)) {
                    charDict[c]++;
                } else {
                    charDict.Add(c, 1);
                }
            }

            Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
            
            foreach (KeyValuePair<char, int> kvp in charDict) {
                if (frequencyDictionary.ContainsKey(kvp.Value)) {
                    frequencyDictionary[kvp.Value]++;
                } else {
                    frequencyDictionary.Add(kvp.Value, 1);
                }
            }

            return s.Length % charDict.Count <= 1 ? "YES" : "NO"; // Has not worked
        }

        public static int AlternatingCharacters(string s) {
            //List<char> list = new List<char>();
            //list.Add(s[0]);
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++) {
                if (s[i] == s[i+1]) {
                    //list.Add(s[i]);
                    count++;
                }
            }

            return count;
            //return s.Length - count;
            //return s.Length - list.Count;       
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
