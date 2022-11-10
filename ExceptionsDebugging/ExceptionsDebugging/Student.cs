using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDebugging
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static int Count = 0;

        public Student()
        {
            Count++;
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Count++;
        }
    }
}
