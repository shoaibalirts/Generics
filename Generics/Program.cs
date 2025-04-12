using ClassLibrary1;
using static System.Console;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                User<int> user1 = new User<int>();
                User<bool> user2 = new User<bool>();
                user1.RegistrationStatus = 1234;
                user2.RegistrationStatus = true;
                WriteLine(user1.RegistrationStatus);
                WriteLine(user2.RegistrationStatus);

                Human<int> std1 = new Human<int>();
                Human<string> std2 = new Human<string>();

                std1.Rank = 1;
                std2.Rank = "Absent";
                WriteLine(std1.Rank);
                WriteLine(std2.Rank);

                Person<int, int> person1 = new Person<int, int>();
                Person<int, string> person2 = new Person<int, string>();
                person1.PersonNumber = 1;
                person1.Age = 25;
                person2.PersonNumber = 2;
                person2.Age = "30-35";

                WriteLine($"person1 number: {person1.PersonNumber}");
                WriteLine($"person1 age: {person1.Age}");
                WriteLine($"person2 number: {person2.PersonNumber}");
                WriteLine($"person2 age: {person2.Age}");

            }

            MarksPrinter<GraduateStudent> graduatestudent1 = new MarksPrinter<GraduateStudent>();
            graduatestudent1.stu = new GraduateStudent() { Marks = 80 };
            graduatestudent1.PrintMarks();

        }
    }
}
