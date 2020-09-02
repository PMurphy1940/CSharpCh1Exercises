using System;

namespace GarysGarage {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();
            Zero fxs = new Zero () {
                MainColor = "Electric blue",
                SaddleBags = 2
            };
            Tesla modelS = new Tesla () {
                MainColor = "Slate Grey",
                Doors = 4
            };
            Cessna mx410 = new Cessna () {
                MainColor = "White",
                Wings = "mostly intact"
            };

            Ram definitelyNotAnF150 = new Ram () {
                MainColor = "Yellow",
                AddOns = "gun rack"
            };

            fxs.Drive ();
            fxs.Turn ();
            fxs.Stop ();
            modelS.Drive ();
            modelS.Turn ();
            modelS.Stop ();
            mx410.Drive ();
            mx410.Turn ();
            mx410.Stop ();
            definitelyNotAnF150.Drive ();
            definitelyNotAnF150.Turn ();
            definitelyNotAnF150.Stop ();
        }

        public class Tesla : Vehicle {
            public double BatteryKWh { get; set; }
            public int Doors { get; set; }
            public void ChargeBattery () {
                // method definition omitted
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

        public class Zero : Vehicle // Electric motorcycle
        {
            public double BatteryKWh { get; set; }

            public int SaddleBags { get; set; }

            public void ChargeBattery () {
                // method definition omitted
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

}