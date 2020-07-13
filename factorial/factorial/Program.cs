using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            int i,number;
            Console.WriteLine("Enter a number");
            number =int.Parse( Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("The factorial of the Entered number "+number+" is: "+factorial);



        }
    }
}
