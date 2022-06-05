using ClassesDemo.Classes;

// johnsCurrentCar is on the stack.
// new Car() is in the heap.
// Create instance and set prop aferward.
Car johnsCurrentCar = new Car();

// What actually happens is that C# calls Car.Make.set("Mazda");
// Just makes code less tedious, so you don't manually have to set;
johnsCurrentCar.Make = "Mazda";

// What actually happens is ... johnsCurrentCar.Make.get()

johnsCurrentCar.Color = "Purple";

johnsCurrentCar.Drive();

Console.WriteLine($"John is in a {johnsCurrentCar.Color} {johnsCurrentCar.Make}. Is he driving? {johnsCurrentCar.IsDriving}.");

// Create an instance and set props in one step.
Car johnsLastCar = new Car()
{
    Make = "Ford",
    Color = "Black"
};


Console.WriteLine($"John was in a {johnsLastCar.Color} {johnsLastCar.Make}. Was he driving? {johnsLastCar.IsDriving}.");

Car johnsFirstCar = new Car("Toyota Celica", "Gold", 4);

Console.WriteLine($"John was in a {johnsFirstCar.Color} {johnsFirstCar.Make}. Was he driving? {johnsFirstCar.IsDriving}.");
Console.WriteLine(johnsFirstCar.DriveTrain.Cylinders);

// after the program runs, this all gets taken into garbage collection.