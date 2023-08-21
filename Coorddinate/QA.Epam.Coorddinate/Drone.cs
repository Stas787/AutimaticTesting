using System;
using System.Collections.Generic;
using System.Text;

namespace QA.Epam.Coorddinate
{
    internal class Drone: IFlyable
    {
        public static Coordinates FirstPointCoordinates { get; set; }

        public Drone(int x1, int y1, int z1)
        {
            FirstPointCoordinates = new Coordinates(x1, y1, z1);
        }

        /// <summary>
        ///Create structure with coordinates of new point
        /// </summary>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public Coordinates FlyTo (int x2, int y2, int z2)
        {
            Coordinates SecondPointCoordinates = new Coordinates(x2, y2, z2);
            return SecondPointCoordinates;
        }

        /// <summary>
        /// Provide flight time value.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">Speed restrictions</exception>
        /// <exception cref="ArgumentException">Distance restrictions</exception>
        public double GetFlyTime (double speed, int x2, int y2, int z2)
        {
            if(speed > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(speed), "Speed can't be more then 50 km/h due to technical reasin");
            }

            Coordinates SecondPoint = FlyTo(x2, y2, z2);
            double distance = Math.Sqrt((SecondPoint.X1 - FirstPointCoordinates.X1) ^ 2 + 
                (SecondPoint.Y1 - FirstPointCoordinates.Y1) ^ 2 + (SecondPoint.Z1 - FirstPointCoordinates.Z1) ^ 2);

            if (distance > 1000)
            {
                throw new ArgumentException("Distance can't be more theb 1000 km, cause it's more then drone range limit");
            }

            double distanceTime = distance / speed;
            double additionalTime = 0;

            while (distanceTime > 0)
            {
                distanceTime -= 10;
                additionalTime += 1;
            }

            return distanceTime + additionalTime;
        }
    }
}
