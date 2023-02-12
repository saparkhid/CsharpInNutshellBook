using Ch3._22_GenericsExample1;
using System.Collections.Generic;


StackInt myStack = new StackInt();
myStack.Push(5);
myStack.Push(6);
Console.WriteLine(myStack.Pop());

StackString stackString = new StackString();
stackString.Push("Ali");
stackString.Push("Reza");
Console.WriteLine(stackString.Pop());

Student student1 = new Student()
{
    Age = 12,
    Id = 1,
    Name = "Ali"
};

Student student2 = new Student()
{
    Age = 15,
    Id = 2,
    Name = "Mohammad"
};

Console.WriteLine("Using generic stack:");
MyStack<int> stack1 = new MyStack<int>();
MyStack<Student> stack2 = new MyStack<Student>();
stack1.Push(3);
stack1.Push(5);
stack2.Push(student2);
stack2.Push(student1);
Console.WriteLine(stack2.Pop());
Console.WriteLine(stack1.Pop());
