using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Aggregate
{
    internal class Transmission
    {
        public string Type { get; set; }

        public string Manufacturer { get; set; }

        public int NumberOfGears { get; set; }

        public Transmission(string type, string manufacturer, int numberOfGears)
        {
            if (numberOfGears < 0 || numberOfGears > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfGears), $"{numberOfGears} is not correct");
            }

            Type = type;
            Manufacturer = manufacturer;
            NumberOfGears = numberOfGears;
        }

        public override string ToString()
        {
            return $"Transmission: Type - {Type}, made in {Manufacturer}, number of gears - {NumberOfGears}";
        }
    }
}
