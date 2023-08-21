using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Aggregates
{
    [Serializable]
    public class Chassis
    {
        public int NumberOfWheels { get; set; }

        public int Number { get; set; }

        public int PermissibleLoad { get; set; }

        public Chassis()
        {
        }

        public Chassis(int numberOfWheels, int number, int permissibleLoad)
        {
            if (numberOfWheels < 0 || numberOfWheels > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfWheels), $"{numberOfWheels} is not correct");
            }

            if (permissibleLoad < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(permissibleLoad), $"{permissibleLoad} can't be less then 0");
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
