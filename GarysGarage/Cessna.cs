using System;

namespace GarysGarage {
    public class Cessna : Vehicle, IGasolineVehicles // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public double StartingTankLevel { get; set; }

        public string CurrentTankPercentage { get; set; }

        public string Wings { get; set; }

        public double tankMath () {
            return (StartingTankLevel / FuelCapacity);
        }
        public void RefuelTank () {
            string Fill = CurrentTankPercentage;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear ();
            Console.WriteLine ($"Filling {MainColor} Cessna");
            Console.WriteLine ("Fueling...");
            Console.WriteLine ($"Tank at ");

            do {
                Console.Write ($"{Fill}");
                System.Threading.Thread.Sleep (400);
                StartingTankLevel += 3;
                Console.ForegroundColor = ConsoleColor.DarkRed;

                if (tankMath () >= 1) {
                    Console.ForegroundColor = ConsoleColor.Gray;
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
            Console.WriteLine ($"The doctor flies off in his {MainColor} Cessna, unaware that his wings are {Wings}. Zooooooom!");
        }
    }
}