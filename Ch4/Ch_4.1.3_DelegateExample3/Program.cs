using Ch_4._1._3_DelegateExample3;

Car car1 = new Car("McLaren2023");
Light light = new Light(25);

CarPrinter carInfoDelegateInstance = car1.PrintCar;

carInfoDelegateInstance.Invoke();
Console.WriteLine(carInfoDelegateInstance.Method);
Console.WriteLine("Instance:" + carInfoDelegateInstance.Target);

carInfoDelegateInstance = light.Print;

Console.WriteLine(carInfoDelegateInstance.Method);
Console.WriteLine("Instance:" + carInfoDelegateInstance.Target);

//static
carInfoDelegateInstance = Car.Power;
Console.WriteLine(carInfoDelegateInstance.Method);
Console.WriteLine("Instance:"+(carInfoDelegateInstance.Target??"Empty"));

ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
delegate void CarPrinter();
