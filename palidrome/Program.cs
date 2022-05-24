using System;

namespace palidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, sum = 0,temp;
            Console.Write("Enter the no=");
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = (sum*10)+r;
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("NO is palidrone: "+sum);
                
            }
            else
            {
                Console.WriteLine("No is not palidrone : "+sum);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
