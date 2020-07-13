using System;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter value for the divisor");
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for the divident");
            int divident = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------");
            for(int i=1;i<=divident;i++)
            {
                if(i%divisor==0)
                {
                    Console.WriteLine(i + " ");
                    count++;
                }
            }
            Console.WriteLine("The number of times"+divisor+" is divisible by"+divident+"is: "+count);
            
        }
    }
}
