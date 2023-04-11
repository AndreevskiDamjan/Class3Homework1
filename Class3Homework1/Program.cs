using Class3Homework1.Entities;

foreach (var vehicle in DB.Vehicles)
{
    vehicle.PrintVehicle();
}

Console.WriteLine();

var newCar = new Car() { Id = 123, Type = "Coupe", YearOfProduction = 2021, BatchNumber = 45645, FuelTank = 60, CountriesOfProduction = new List<string>() { "Macedonia", "Serbia" } };
var newBike = new Bike() { Id = 456, Type = "Sedan", YearOfProduction = 2021, BatchNumber = 4738727, Color = "Black" };

Console.WriteLine($"Car validation result: {Validator.Validate(newCar)}");
Console.WriteLine($"Bike validation result: {Validator.Validate(newBike)}");

