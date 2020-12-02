using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg1 = args[0];
            int intArg1 = int.Parse(arg1);

            string arg2 = args[1];
            int intArg2 = int.Parse(arg2);

            Console.WriteLine("Enter the first value");
            string value1 = Console.ReadLine();
            int a = int.Parse(value1);

            Console.WriteLine("Enter the second value");
            string value2 = Console.ReadLine();
            int b = int.Parse(value2);

            int c = a + b + intArg1 + intArg2;
            Console.Write(value1 + "+" + value2 + "+" + intArg1 + "+" + intArg2 + "=" + c);
            

           
        }
    }
}
