public class A
{
    int x = 1; // Executes 3rd
    public A(int x)
    {
        // Executes 4th
    }
}

public class B : A
{
    int y = 1; // Executes 1st
    public B(int x)
    : base(x + 1) // Executes 2nd
    {
        // Executes 5th
    }
}