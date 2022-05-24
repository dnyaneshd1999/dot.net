using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,Choice;
            Console.WriteLine("===Calculator===");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("=================");
            Console.WriteLine("Enter the Two no a and b :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the choice :");
            Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Addtion = " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Substraction = " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication = " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division = " + (a / b));
                    break;
                default:
                    Console.WriteLine("Please Enter Correct Choice");
                    break;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
