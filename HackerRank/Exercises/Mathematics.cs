using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Mathematics {
        static int[] findPoint(int px, int py, int qx, int qy) {
            // Given two coordinates (x1, y2), (x2, y2), find the point reflection aka inversion

            int[] result = new int[2];

            result[0] = qx - px + qx;
            result[1] = qy - py + qy;

            return result;
        }

    }
}
