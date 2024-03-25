// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;

public abstract class Container
{
    protected int LoadMass { get; set; }
    protected int Height { get; set; }
    protected int Mass { get; set; }
    protected double Depth { get; set; }
    protected static int Num = 0;
    public String SerialNumber { get; set; }
    protected int MaxLoad { get; set; }
    protected String ContainerType { get; set; } = "Object";

    protected Container(int height, int mass, double depth, int maxLoad)
    {
        Height = height;
        Mass = mass;
        Depth = depth;
        MaxLoad = maxLoad;
        LoadMass = 0;
        Num++;
    }

    public abstract void Empty();

    public abstract void Load(int load);

    public override string ToString()
    {
        return SerialNumber + " " + ContainerType + " " + LoadMass + " " + MaxLoad + " " + Height + " " + Mass + " " + Depth;
    }

    public Exception OverfillException { get; set; }
}