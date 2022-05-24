using System;

namespace Vote_Eligible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int i =Convert.ToInt32(Console.ReadLine());
            //int i = 18;
            if(i>18 && i>60)
            {
                Console.WriteLine("Votes Eligible");
                Console.WriteLine("senior citizien");
      
            }
            else
            {
                Console.WriteLine("Vote not eligible");
            }
        }
    }
}
