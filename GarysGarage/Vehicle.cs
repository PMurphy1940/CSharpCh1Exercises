using System;

public class Vehicle {
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive () {
        Console.WriteLine ("Vrooom!");
    }

    public virtual void Turn() {
        Console.WriteLine("There's a boot on this vehicle. It can't turn");
    }

    public virtual void Stop () {
        Console.WriteLine("There's a boot on this vehicle. It can't move, therefore it's unable to stop.");
    }
}