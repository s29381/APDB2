namespace ConsoleApp1;

public class Ship
{
    protected List<Container> Containers { get; set; }
    protected int MaxSpeed { get; set; }
    protected int MaxContainerNumber { get; set; }
    protected int MaxWeight { get; set; }

    public Ship(int maxSpeed, int maxContainerNumber, int maxWeight)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainerNumber = maxContainerNumber;
        MaxWeight = maxWeight;
    }
    
    public void Load(Container container)
    {
        Containers.Add(container);
    }
    
    public void LoadAll(List<Container> containers)
    {
        foreach (var container in containers)
        {
            Containers.Add(container);
        }
    }
    
    public void Unload(Container container)
    {
        Containers.Remove(container);
    }
    
    public void Empty()
    {
        Containers.Clear();
    }
    
    public void Replace(String serialnumber, Container container)
    {
        int index;
        if ((index = Containers.FindIndex(c => c.SerialNumber.Equals(serialnumber))) != null)
        {
            Containers[index] = container;
        }
    }
    
    public void Swap(Ship ship, Container container)
    {
        Containers.Remove(container);
        ship.Load(container);
    }

    public String Info()
    {
        return "speed=" + MaxSpeed + ", MaxContainerNuber=" + MaxContainerNumber + ", MaxWeight=" + MaxWeight;
    }
    public String InfoAll()
    {
        String s = Info();
        foreach (var c in Containers)
        {
            s += "\n" + c;
        }
        return s;
    }
    
}