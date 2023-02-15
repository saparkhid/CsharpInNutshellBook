using Ch3_22.GenericMethods;
void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}
int x = 10;
int y = 19;
Swap(ref x,  ref y);
Console.WriteLine(x);
Console.WriteLine(y);

string s1 = "ali";
string s2 = "reza";
Swap(ref s1, ref s2);
Console.WriteLine(s1);
Console.WriteLine(s2);

Queue<int, string> codeMapQueue = new Queue<int, string>();
codeMapQueue.Items.Add(new Block<int, string>()
{
    Part1 = 2000,
    Part2 = "Ali"
});

codeMapQueue.Items.Add(new Block<int, string>()
{
    Part1 = 3000,
    Part2 = "Reza"
});

codeMapQueue.Items.Add(new Block<int, string>()
{
    Part1 = 4000,
    Part2 = "Mohammad"
});

