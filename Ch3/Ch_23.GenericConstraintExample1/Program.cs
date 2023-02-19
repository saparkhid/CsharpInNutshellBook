using Ch_23.GenericConstraintExample1;

T Max<T>(T a, T b) where T : IComparable<T>
{
   
    if(a.CompareTo(b) > 0)
    {
        return a;
    }
    else if (a.CompareTo(b) < 0)
    {
        return b;
    }
    ///equal
    return b;
}

int maxIntegers = Max(3, 5);
Console.WriteLine(maxIntegers);
Student st1 = new Student("Ali", 15);
Student st2 = new Student("Reza", 18);
Student maxStudent = Max(st1, st2);
Console.WriteLine(maxStudent);
Console.ReadKey();