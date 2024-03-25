namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        GasContainer Container1 = new GasContainer(3,100,1.2,1000,2000);
        CoolingContainer Container2 = new CoolingContainer(3,100,1.0,1000,"Bananas",14);
        List<Container> ContainerList = new List<Container>(){
            new LiquidContainer(5,150,3.0,2000,false),
            new LiquidContainer(5,150,3.0,2000,false),
            new LiquidContainer(5,150,3.0,2000,false),
            new LiquidContainer(5,150,3.0,2000,false)
            };
        Ship Cargoship1 = new Ship(10,100,40000);
        Ship Cargoship2 = new Ship(10,100,40000);
        Container1.Load(500);
        Cargoship1.Load(Container1);
        Cargoship1.LoadAll(ContainerList);
        Cargoship1.Unload(ContainerList[1]);
        Container1.Empty();
        Cargoship1.Replace(ContainerList[2].SerialNumber, Container2);
        Cargoship1.Swap(Cargoship2, Container2);
        Console.WriteLine(Cargoship1.Info());
        Console.WriteLine(Cargoship1.InfoAll());
        Console.WriteLine(Cargoship2.InfoAll());
    }
}