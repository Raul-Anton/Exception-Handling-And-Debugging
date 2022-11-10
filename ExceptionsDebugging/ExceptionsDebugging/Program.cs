using ExceptionsDebugging;
using System.Diagnostics;

ExceptionMethods exceptionMethod = new ExceptionMethods();

exceptionMethod.Divide(10, 0);



int[] array = new int[] { 1, 2, 3 };

exceptionMethod.WriteArrayNumber(array, 3);



Student student = new Student("Paul", 17);

exceptionMethod.CheckAge(student.Age);

exceptionMethod.GetStudentName(null);



int[] array2 = new int[] { 4, 5, 6 };
Student student2 = new Student("Sina", 20);
Console.WriteLine();
try
{
    exceptionMethod.Divide(10, 1);
    exceptionMethod.WriteArrayNumber(array2, 0);
    exceptionMethod.IsValidAge(student2.Age);
    exceptionMethod.FindStudent(student2);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch(CustomExceptionAge ex)
{
    Console.WriteLine(ex.Message);
}
catch(StudentNotFound ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.Write("{0} {1}", student2.Name, student2.Age);
}

#if DEBUG
{
    Console.WriteLine();
    Console.WriteLine();
    try
    {
        exceptionMethod.Show();
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("I cought an exception");
    }
}
#endif

Debug.WriteLine("We have a total of {0} instances of the Student class",Student.Count);