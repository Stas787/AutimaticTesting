using System;
using System.Collections.Generic;
using System.Text;

namespace QA.Epam.Coorddinate
{
    internal class Bird: IFlyable
    {
        public static Coordinates CurrentPopsition { get; set; }
        
        public Bird(int x1, int y1, int z1)
        {
            CurrentPopsition = new Coordinates(x1, y1, z1);
        }

        /// <summary>
        /// Provide coordinates of the new point
        /// </summary>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public Coordinates FlyTo(int x2, int y2, int z2)
        {
            return new Coordinates(x2, y2, z2);           
        }

        /// <summary>
        /// Calculate flight time
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public double GetFlyTime(double speed, int x2, int y2, int z2)
        {
            Random random = new Random();
            speed = random.Next(20);
            Coordinates newPoint = FlyTo(x2, y2, z2);
            double distance = Math.Sqrt((newPoint.X1 -CurrentPopsition.X1) ^ 2 + 
                (newPoint.Y1 - CurrentPopsition.Y1) ^ 2 + (newPoint.Z1 - CurrentPopsition.Z1) ^ 2);

            return distance / speed;
        }
    }
}
