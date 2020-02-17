using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class DictionariesHashMaps {
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
