namespace ooDemo;

public class RentalSailboat : RentalVehicle
{
    public override void StartEngine()
    {
        throw new Exception("I do not have an engine to start");
    }

    public override void StopEngine()
    {
        throw new Exception("I do not have an engine to stop");
    }
}

public class RentalVehicle
{
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerDay { get; set; }
    public int NumberOfPassengers { get; set; }

    public virtual void StartEngine()
    {
        Console.WriteLine("Turn key to ignition start...");
        Console.WriteLine("Turn key to on");
    }

    public virtual void StopEngine()
    {
        Console.WriteLine("Turn key to off");
    }
}