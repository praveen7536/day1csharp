using System;

namespace numberofword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string s1 = Console.ReadLine();
            string [] sp = s1.Split(" ");
            Console.WriteLine("third word is " + sp[2]);


        }
    }
}
