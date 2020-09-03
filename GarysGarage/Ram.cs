using System;

namespace GarysGarage {
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public string AddOns { get; set; }

        public void RefuelTank () {
            // method definition omitted
        }
        public override void Drive () {
            Console.WriteLine ($"The driver hangs his hat on the {AddOns} and the {MainColor} Ram rolls off. Bruh-bruh-bruh-bruh");
        }
    }
}