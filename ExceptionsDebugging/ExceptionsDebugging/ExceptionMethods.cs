using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDebugging
{
    internal class ExceptionMethods
    {
        public void Divide(int number1, int number2)
        {
            try
            {
                Console.WriteLine(number1 / number2);
            }
            catch(DivideByZeroException)
            {
                DivideByZeroException ex = new DivideByZeroException();
                Console.WriteLine(ex.Message);
            }
        }

        public void WriteArrayNumber(int[] array, int index)
        {
            try
            {
                Console.WriteLine(array[index]);
            }
            catch(IndexOutOfRangeException)
            {
                IndexOutOfRangeException ex = new IndexOutOfRangeException();
                Console.WriteLine(ex.Message);
            }
        }

        public void IsValidAge(int age)
        {
            if (age < 18)
            {
                throw new CustomExceptionAge("Age should be above 18");
            }
            Console.WriteLine("Age is above 18");
        }

        public void CheckAge(int age)
        {
            try
            {
                IsValidAge(age);
            }
            catch (CustomExceptionAge ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void FindStudent(Student student)
        {
            if (student == null)
            {
                throw new StudentNotFound("Student not found");
            }
            Console.WriteLine(student.Name);
        }

        public void GetStudentName(Student student)
        {
            try
            {
                FindStudent(student);
            }
            catch(StudentNotFound ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Show()
        {
            try
            {
                String str = "Hello";
                char ch = str[7];
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("I threw an exception ");
                throw;
            }
        }
    }
}
