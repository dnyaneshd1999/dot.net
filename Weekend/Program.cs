using System;

namespace Weekend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the any No=");
            int i = Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturaday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not Match The No");
                    break;
            }
        }
    }
}
