Student[] students = new Student[10];
T[] Init<T>(T[] arrayList) where T : new()
{
    for(int i = 0; i < arrayList.Length; i++)
    {
        arrayList[i] = new T();
    }

    return arrayList; 
}

students= Init(students);
students[0].Name = "Ali";
class Student
{
    public string Name;

    public Student()
    {

    }

}
