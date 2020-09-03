using System;

namespace GarysGarage {
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public int SaddleBags { get; set; }

        public void ChargeBattery () {

            Console.Clear ();
            Console.WriteLine ($"Charging {MainColor} Zero");
            Console.WriteLine ("Charging...");
            Console.WriteLine ($"Battery at ");

            do {
                Console.Write ($"{CurrentChargePercentage}%");
                System.Threading.Thread.Sleep (300);
                CurrentChargePercentage += 3;
                Console.Write ("\b\b\b");
            } while (CurrentChargePercentage < 100);
            CurrentChargePercentage = 100;
        }

        public override void Drive () {
            Console.WriteLine ($"The hipster put his farmers market groceries into the {SaddleBags} saddlebags on his {MainColor} Zero and glided away ------------");
        }

        public override void Turn () {
            Console.WriteLine ("He turned right out of the farmer's market and headed off toward the lumberjack house.");
        }

        public override void Stop () {
            Console.WriteLine ("His wayfaring came discommodiously to cessation when his maladroitly furled breeches immured themselves in the animating force of his voltaic conveyance.");
        }
    }
}