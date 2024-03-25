namespace ConsoleApp1;

public class GasContainer : Container, IHazardNotifier
{
    protected int Preasure { get; set; }

    public GasContainer(int height, int mass, double depth, int maxLoad, int preasure) : base(height, mass, depth, maxLoad)
    {
        ContainerType = "Gas";
        Preasure = preasure;
        SerialNumber = "KON-" + ContainerType[0] + "-" + Num;
    }

    public override void Empty()
    {
        MaxLoad = (int)(MaxLoad * 0.05);
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