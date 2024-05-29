using SOLID101.LSP;

// Test - LSP

IEnginePowered car = new Car();
car.StartEngine(); // Outputs "Starting the car engine."

Vehicle electricCar = new ElectricCar();
// electricCar.StartEngine(); // This line won't compile because ElectricCar does not implement IEnginePowered since ElectricCar does not need to implement engine related methods.
