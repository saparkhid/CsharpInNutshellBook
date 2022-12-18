// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
WriteData("agent 1");
WriteData("agent 2");
Console.ReadKey();
void WriteData(string sender)
{
    Square(7);
    Cube(7);
    static void Square(int v)
    {
        int sq = v * v;
        Console.WriteLine("because static modifier, the sender variable from outer function is not visible.");
    }
    void Cube(int v)
    {
        int c = v * v * v;
        Console.WriteLine($"{sender}:c");
    }
}