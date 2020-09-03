using System;
using System.Collections.Generic;

namespace GarysGarage {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();
            Zero fxs = new Zero () {
                MainColor = "Electric blue",
                SaddleBags = 2,
                CurrentChargePercentage = 7
            };
            Zero fx = new Zero () {
                MainColor = "Vespa blue",
                SaddleBags = 0,
                CurrentChargePercentage = 12
            };
            Tesla modelS = new Tesla () {
                MainColor = "Slate Grey",
                Doors = 4,
                CurrentChargePercentage = 22
            };
            Cessna mx410 = new Cessna () {
                MainColor = "White",
                Wings = "mostly intact"
            };

            Ram definitelyNotAnF150 = new Ram () {
                MainColor = "Yellow",
                AddOns = "gun rack"
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle> () {
                fx,
                fxs,
                modelS
            };

            Console.WriteLine ("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles) {
                Console.WriteLine ($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in electricVehicles) {
                // This should charge the vehicle to 100%
                ev.ChargeBattery ();
            }

            foreach (IElectricVehicle ev in electricVehicles) {
                Console.WriteLine ($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            // fxs.Drive ();
            // fxs.Turn ();
            // fxs.Stop ();
            // modelS.Drive ();
            // modelS.Turn ();
            // modelS.Stop ();
            // mx410.Drive ();
            // mx410.Turn ();
            // mx410.Stop ();
            // definitelyNotAnF150.Drive ();
            // definitelyNotAnF150.Turn ();
            // definitelyNotAnF150.Stop ();
        }

        // List<???> gasVehicles = new List<???>() {
        //         definitelyNotAnF150, mx410
        //     };

        //     Console.WriteLine("Gas Vehicles");
        //     foreach(??? gv in gasVehicles)
        //     {
        //         Console.WriteLine($"{gv.CurrentTankPercentage}");
        //     }

        //     foreach(??? gv in gasVehicles)
        //     {
        //         // This should completely refuel the gas tank
        //         gv.RefuelTank();
        //     }

        //     foreach(??? gv in gasVehicles)
        //     {
        //         Console.WriteLine($"{gv.CurrentTankPercentage}");
        //     }
    }
}