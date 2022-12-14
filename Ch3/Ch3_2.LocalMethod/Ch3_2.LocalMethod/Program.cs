// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
WriteData();
Console.ReadKey();
void WriteData()
{
    Console.WriteLine(Square(7));
    Console.WriteLine(Cube(7));
    int Square(int v)
    {
        return v * v;
    }
    int Cube(int v)
    {
        return v * v * v;
    }
}