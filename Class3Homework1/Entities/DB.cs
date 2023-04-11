namespace Class3Homework1.Entities
{
    public static class DB
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>()
    {
        new Car() { Id = 123, Type = "Coupe", YearOfProduction = 2022, BatchNumber = 123, FuelTank = 80, CountriesOfProduction = new List<string>() { "USA", "Japan" } },
        new Bike() { Id = 456, Type = "Sedan", YearOfProduction = 2022, BatchNumber = 456, Color = "Red" },
        new Vehicle() { Id = 789, Type = "Hemi", YearOfProduction = 2022, BatchNumber = 789 }
        };
    }

}
