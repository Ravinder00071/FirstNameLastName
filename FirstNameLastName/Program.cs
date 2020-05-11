using System;

namespace FirstNameLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is Name?");
            Console.Write("your first name: ");
            String FirstName;
            FirstName = Console.ReadLine();

            string LastName;
            Console.Write("your last name");
            LastName = Console.ReadLine();
            Console.WriteLine("Hi " + FirstName + " " + LastName);
            Console.ReadLine();

        }
    }
}
