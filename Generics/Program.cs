using System;
using ClassLibrary1;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User<int> user1 = new User<int>();
            User<bool> user2 = new User<bool>();
            user1.RegistrationStatus = 1234;
            user2.RegistrationStatus = true;
            Console.WriteLine(user1.RegistrationStatus);
            Console.WriteLine(user2.RegistrationStatus);

            Student<int> std1 = new Student<int>();
            Student<string> std2 = new Student<string>();

            std1.Rank = 1;
            std2.Rank = "Absent";
            Console.WriteLine(std1.Rank);
            Console.WriteLine(std2.Rank);

        }
    }
}
