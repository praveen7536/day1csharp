using System;

namespace nameAndWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            String str = Console.ReadLine();
            int num = str.Length;
            Console.WriteLine("You have Entered your name as " + str + " and it is of  length " + num);
            

        }
    }
}
