using System;

namespace ClassLibrary1
{
    public class Sample
    {
        // generic method that can accept a parameter of any type
        public void PrintData<T>(T obj) where T : class
        {
            if (obj.GetType() == typeof(RTSStudent))
            {
                RTSStudent temp = obj as RTSStudent;
                Console.WriteLine(temp.Marks);
            }
            else if (obj.GetType() == typeof(Employee))
            {
                Employee temp = obj as Employee;
                Console.WriteLine(temp.Salary);
            }
        }
    }
}
