using System;

namespace GarysGarage {
    public class Tesla : Vehicle, IElectricVehicle {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }
        public int Doors { get; set; }
        public void ChargeBattery () {
            /* Incrementally charge the batteries */
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear ();
            Console.WriteLine ($"Charging {MainColor} Tesla");
            Console.WriteLine ("Charging...");
            Console.WriteLine ($"Battery at ");

            do {
                if (CurrentChargePercentage < 25) {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                } else if (CurrentChargePercentage > 25 && CurrentChargePercentage < 50) {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else if (CurrentChargePercentage > 50 && CurrentChargePercentage < 75) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                } else if (CurrentChargePercentage > 75 && CurrentChargePercentage < 100) {
                    Console.ForegroundColor = ConsoleColor.Green;
                };
                Console.Write ($"{CurrentChargePercentage}%");
                System.Threading.Thread.Sleep (300);
                CurrentChargePercentage += 3;
                Console.Write ("\b\b\b");
            } while (CurrentChargePercentage < 100);
            CurrentChargePercentage = 100;
        }

        public override void Drive () {
            Console.WriteLine ($"The lawyer's {MainColor} {Doors} door Tesla glides silently behind the Ambulance. SHHHHHhhhhhhh.");
        }

        public override void Turn () {
            Console.WriteLine ("He turns left folowing the Ambulance.");
        }

        public override void Stop () {
            Console.WriteLine ("He glides to a stop at the Emergency Room doors.");
        }
    }
}