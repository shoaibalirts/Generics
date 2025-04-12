using System;

namespace ClassLibrary1
{
    public abstract class Student
    {
        public abstract int Marks { get; set; }
    }

    public class GraduateStudent : Student
    {
        public override int Marks { get; set; }
    }
    public class PostGraduateStudent : Student
    {
        public override int Marks { get; set; }
    }

    // generic class with constraint (want to accept Student or its child classes only)
    public class MarksPrinter<T> where T : Student
    {
        // stu is a field with generic type T
        public T stu;
        public void PrintMarks()
        {
            Student temp = (Student)stu; // type cast the stu field to Student 
            Console.WriteLine(temp.Marks);
        }
    }
}
