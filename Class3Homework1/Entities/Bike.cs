namespace Class3Homework1.Entities
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public new void PrintVehicle()
        {
            Console.WriteLine($"Year of Production: {YearOfProduction}, Color: {Color}");
        }
    }
}
