namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    protected bool IsHazardous { get; set; }
    public LiquidContainer(int height, int mass, double depth, int maxLoad, bool isHazardous) : base(height, mass, depth, maxLoad)
    {
        ContainerType = "Liquid";
        IsHazardous = isHazardous;
        SerialNumber = "KON-" + ContainerType[0] + "-" + Num;
    }
    public void Hazard()
    {
        Console.WriteLine("Doszło od niebezpiecznego zajścia z " + SerialNumber);
        throw OverfillException;
    }

    public override void Empty()
    {
        LoadMass = 0;
    }

    public override void Load(int load)
    {
        if (IsHazardous)
        {
            if (LoadMass + load > MaxLoad / 2)
            {
                Hazard();
            }
            LoadMass += load;
        }
        else
        {
            if (LoadMass + load > MaxLoad  * 0.9 )
            {
                Hazard();
            }
            LoadMass += load;
        }
    }
}