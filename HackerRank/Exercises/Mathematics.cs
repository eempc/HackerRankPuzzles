using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Mathematics {
        static int[] findPoint(int px, int py, int qx, int qy) {
            // Given two coordinates (x1, y2), (x2, y2), find the point reflection aka inversion
            // Basically it is opposite of finding the midpoint
            // But technically there are two refletion points when given two coordinates
            // But we are tasked with the finding one based on the order of the given points
            int[] result = new int[2];

            result[0] = qx - px + qx; // Simplified to (2 * qx - px)
            result[1] = qy - py + qy;

            return result;
        }

    }
}
