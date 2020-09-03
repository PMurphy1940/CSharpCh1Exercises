using System;

namespace GarysGarage {
    public class Ram : Vehicle, IGasolineVehicles // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public double StartingTankLevel { get; set; }
        public string CurrentTankPercentage { get; set; }
        public string AddOns { get; set; }

        public double tankMath () {
            return (StartingTankLevel / FuelCapacity);
        }
        public void RefuelTank () {
            string Fill = CurrentTankPercentage;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear ();
            Console.WriteLine ($"Filling {MainColor} Ram");
            Console.WriteLine ("Fueling...");
            Console.WriteLine ($"Tank at ");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            do {
                Console.Write ($"{Fill}");
                System.Threading.Thread.Sleep (400);
                StartingTankLevel += 1;

                if (tankMath () >= 1) {
                    Fill = "Full";
                } else if (tankMath () >.75 && tankMath () < 1) {
                    Fill = "3/4";
                    Console.ForegroundColor = ConsoleColor.Green;
                } else if (tankMath () >.5 && tankMath () < .75) {
                    Fill = "1/2";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                } else if (tankMath () >.25 && tankMath () < .50) {
                    Fill = "1/4";
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write ("\b\b\b");
            } while (Fill != "Full");
            CurrentTankPercentage = Fill;

        }
        public override void Drive () {
            Console.WriteLine ($"The driver hangs his hat on the {AddOns} and the {MainColor} Ram rolls off. Bruh-bruh-bruh-bruh");
        }
    }
}