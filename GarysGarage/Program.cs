using System;
using System.Collections.Generic;

namespace GarysGarage {
    class Program {
        static void Main (string[] args) {
            Console.ForegroundColor = ConsoleColor.Gray;
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
                FuelCapacity = 150.0,
                StartingTankLevel = 19.0,
                CurrentTankPercentage = "1/8",
                Wings = "mostly intact"
            };

            Ram definitelyNotAnF150 = new Ram () {
                MainColor = "Yellow",
                FuelCapacity = 35.0,
                StartingTankLevel = 3.0,
                CurrentTankPercentage = "1/8",
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

            List<IGasolineVehicles> gasVehicles = new List<IGasolineVehicles> () {
                definitelyNotAnF150,
                mx410
            };

            Console.WriteLine ("Gas Vehicles");
            foreach (IGasolineVehicles gv in gasVehicles) {
                Console.WriteLine ($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasolineVehicles gv in gasVehicles) {
                // This should completely refuel the gas tank
                gv.RefuelTank ();
            }
            Console.Clear ();
            foreach (IElectricVehicle ev in electricVehicles) {
                string type = ev.GetType ().ToString ();
                string[] splitType = type.Split ('.');
                string message =
                    $"{ev.MainColor} {splitType[1]} batteries charged to {ev.CurrentChargePercentage}%";
                MooseSays (message);
            }

            foreach (IGasolineVehicles gv in gasVehicles) {
                string type = gv.GetType ().ToString ();
                string[] splitType = type.Split ('.');
                string message = $"{gv.MainColor} {splitType[1]} fuel tank {gv.CurrentTankPercentage}";
                MooseSays (message);
            }
        }

        static void MooseSays (string message) {
            Console.Clear ();
            Console.WriteLine ($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`

    Press Any Key To Continue");
            Console.ReadKey ();
        }
    }
}