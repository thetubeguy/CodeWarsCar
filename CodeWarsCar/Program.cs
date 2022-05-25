using CodeWarsCar;

ICar myCar = new Car();


Console.WriteLine($"Engine started: {myCar.EngineIsRunning}");

myCar.EngineStart();

Console.WriteLine($"Engine started: {myCar.EngineIsRunning}");
