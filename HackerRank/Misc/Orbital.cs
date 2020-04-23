using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Misc {
    class Orbital {
        static int massEarth = (int)(5.97237 * Math.Pow(10, 24)); // kg
        static double G = 6.67430 * Math.Pow(10, -11); // m^3/(kg*s^2)
        static double muEarth = 3.9860004418 * Math.Pow(10, 14); // m^3/s^2
        static double earthRadius = 6371000; // m (mean)  cognate with semi-major axis

        // Calculate the orbital velocity required for a 600 km altitude altitude assuming no eccentricity and the mass of the craft is neglible
        public static double GetVelocityOfCircularEarthOrbit(int altitude = 409000) {
            double radius = earthRadius + altitude;
            return Math.Sqrt(muEarth / radius);
        }

        

    }
}
