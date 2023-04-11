namespace Class3Homework1.Entities
{
    public class Car : Vehicle

    {
        public int FuelTank { get; set; }
        public List<string> CountriesOfProduction { get; set; }

        public new void PrintVehicle()
        {
            Console.WriteLine($"Type: {Type}, Countries of Production: {string.Join(", ", CountriesOfProduction)}");
        }
    }
}