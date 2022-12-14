// See https://aka.ms/new-console-template for more information
using Ch3_1.Raphson;
using Ch3_1.UltraMath;

Raphson raphson = new Raphson();
double d= raphson.Estimate();
Console.WriteLine($"Phi:{MathHelper.Phi}");
Console.WriteLine($"estimated value {d}");
Console.ReadKey();
