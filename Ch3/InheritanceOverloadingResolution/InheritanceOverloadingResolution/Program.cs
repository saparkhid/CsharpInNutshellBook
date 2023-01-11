using InheritanceOverloadingResolution;
AutoPrinter printer = new AutoPrinter();

Car c1 = new Car("C1"); //compile time
Vehicle v1 = new Car("VC2");//compile time
printer.Print(c1);
printer.Print(v1);
printer.Print((dynamic)v1);//run time: outputs Car:VC2 , since v1 is a car at runtime
