using System;

public record Car(string Brand, string Model, int Year);
public record ElectricCar(string Brand, string Model, int Year, int BatteryCapacity) : Car(Brand, Model, Year);

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", "Camry", 2020);
        ElectricCar electricCar = new ElectricCar("Tesla", "Model 3", 2021, 75);
        Console.WriteLine("Car and ElectricCar Records:");
        Console.WriteLine(car);
        Console.WriteLine(electricCar);

        Car polymorphicCar = electricCar; 
        Console.WriteLine("Polymorphic Car:");
        Console.WriteLine(polymorphicCar);

        Console.WriteLine($"Battery Capacity: {electricCar.BatteryCapacity} kWh");

    }
    

}