namespace GarysGarage {
    public interface IElectricVehicle {
        double BatteryKWh { get; }

        string MainColor { get; }

        int CurrentChargePercentage { get; }

        void ChargeBattery ();

    }
}