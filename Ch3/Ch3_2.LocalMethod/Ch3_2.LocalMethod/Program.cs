Console.WriteLine("Hello, World!");
WriteData("agent 1");
WriteData("agent 2");
Console.ReadKey();
void WriteData(string sender)
{
    Square(7);
    Cube(7);
    void Square(int v)
    {
        int sq= v * v;
        Console.WriteLine($"{sender}:sq");
    }
    void Cube(int v)
    {
        int c= v * v * v;
        Console.WriteLine($"{sender}:c");
    }
}