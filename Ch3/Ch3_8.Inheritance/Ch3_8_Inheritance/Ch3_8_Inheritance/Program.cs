using Ch3_8_Inheritance;
Asset a1 = new Asset();

try
{
    Money m1 = (Money)a1;
    /*
    Stock h1 = a1 as Stock;
    if (h1 == null)
    {
        Console.WriteLine("Casting failed");
    }*/
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();
