using System;

namespace palidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("Enter the any string");
            str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            String str_reverse = new string(arr);
            if(str.Equals(str_reverse))
            {
                Console.WriteLine("Given String is a palidrome");
            }
            else
            {
                Console.WriteLine("Given String is not a palidrome");
            }
            /* int r, sum = 0,temp;
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
           */
        }
    }
}
