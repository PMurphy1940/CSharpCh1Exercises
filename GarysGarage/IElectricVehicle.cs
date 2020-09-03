namespace GarysGarage {
    public interface IElectricVehicle {
        double BatteryKWh { get; }

        int CurrentChargePercentage { get; }

        void ChargeBattery ();

    }
}