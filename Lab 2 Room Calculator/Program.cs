using System;

namespace Lab_2_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Room Detail Generator!");

            string userResponse = "y";

            while (userResponse == "y")
            {
                Console.WriteLine("Enter Length: ");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height");
                double height = double.Parse(Console.ReadLine());

                double perimeter = (length * 2) + (width * 2);

                double area = (length * width);

                double volume = (length * width * height);

                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Continue? (y/n)");
                userResponse = Console.ReadLine().ToLower();
            }







        }
    }
}