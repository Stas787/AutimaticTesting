using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Aggregate
{
    internal class Chassis
    {
        public int NumberOfWheels { get; set; }

        public int Number { get; set; }

        public int PermissibleLoad { get; set; }

        public Chassis(int numberOfWheels, int number, int permissibleLoad)
        {
            if (permissibleLoad < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(permissibleLoad), $"{permissibleLoad} can't be less then 0");
            }

            if (numberOfWheels < 0 || numberOfWheels > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfWheels), $"{numberOfWheels} is not correct");
            }

            NumberOfWheels = numberOfWheels;
            Number = number;
            PermissibleLoad = permissibleLoad;
        }

        public override string ToString()
        {
            return $"Chassis: number of wheels - {NumberOfWheels}, number - {Number}, permissible load - {PermissibleLoad}";
        }
    }
}
