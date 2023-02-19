using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_23.GenericConstraintExample1
{
    public class Student : IComparable<Student>
    {
        private string name;
        private int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Student? other)
        {
            if (this.age > other.age)
            {
                return 1;
            }
            else if (this.age < other.age)
            {
                return -1;
            }
            return 0;
        }
        public override string ToString()
        {
            return this.name + " is " + this.age.ToString() +" years old.";
        }
    }
}
