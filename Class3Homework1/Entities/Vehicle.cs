public class Vehicle
{
    public int Id { get; set; }
    public string Type { get; set; }
    public int YearOfProduction { get; set; }
    public int BatchNumber { get; set; }

    public void PrintVehicle()
    {
        Console.WriteLine($"Id: {Id}\nType: {Type}\nYear of Production: {YearOfProduction}");
    }
}