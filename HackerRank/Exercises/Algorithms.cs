using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Algorithms {

        static List<int> GradingStudents(List<int> grades) {
            List<int> result = new List<int>();

            foreach (int x in grades) {
                if (x < 38) {
                    result.Add(x);
                } else if (x % 10 == 3 || x % 10 == 4) {
                    result.Add(x + 5 - (x % 10));
                } else if (x % 10 == 8 || x % 10 == 9) {
                    result.Add(x + 10 - (x % 10));
                } else {
                    result.Add(x);
                }
            }

            return result;
        }

    }
}
