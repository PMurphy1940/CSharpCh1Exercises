namespace GarysGarage {
    public interface IGasolineVehicles {

        double FuelCapacity { get; }
        double StartingTankLevel { get; }
        string CurrentTankPercentage { get; }
        string MainColor { get; }
        void RefuelTank ();
    }
}