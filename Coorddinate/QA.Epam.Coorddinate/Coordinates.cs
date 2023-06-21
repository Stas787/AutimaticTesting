using System;
using System.Collections.Generic;
using System.Text;

namespace QA.Epam.Coorddinate
{
    internal struct Coordinates
    {
        public int X1 {get;set;}

        public int Y1 {get;set;}

        public int Z1 {get;set;}

        public Coordinates(int x1, int y1, int z1)
        {
            X1 = x1;
            Y1 = y1; 
            Z1 = z1; 
        }
    }
}
