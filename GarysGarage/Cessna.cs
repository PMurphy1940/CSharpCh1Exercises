using System;

namespace GarysGarage {
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public string Wings { get; set; }

        public void RefuelTank () {
            // method definition omitted
        }
        public override void Drive () {
            Console.WriteLine ($"The doctor flies off in his {MainColor} Cessna, unaware that his wings are {Wings}. Zooooooom!");
        }
    }
}