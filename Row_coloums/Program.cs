using System;

namespace Row_coloums
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<8;i++)
            {
                for(int j=0;j<8;j++)
                {
                    if(i==1 || i==8 || j==1 || j==8-i+1 ||i==j ||j==8)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write();
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
