namespace ConsoleApp1;

public class CoolingContainer : Container, IHazardNotifier
{
    protected String ProductType { get; set; }
    protected int Temperature { get; set; }

    public CoolingContainer(int height, int mass, double depth, int maxLoad, String productType, int temperature) : base(height, mass, depth, maxLoad)
    {
        ContainerType = "Colling";
        ProductType = productType;
        Temperature = temperature;
        SerialNumber = "KON-" + ContainerType[0] + "-" + Num;
    }

    public override void Empty()
    {
        LoadMass = 0;
    }

    public override void Load(int load)
    {
        if (LoadMass + load > MaxLoad)
        {
            Hazard();
        }

        LoadMass += load;
    }

    public void Hazard()
    {
        Console.WriteLine("Doszło od niebezpiecznego zajścia z " + SerialNumber);
        throw OverfillException;
    }
}