using System;

namespace HomeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you," + name + "!");

            Console.WriteLine("Tell me the first number.");
            string num1 = Console.ReadLine();
            int a = int.Parse(num1);

            Console.WriteLine("And now, tell me please the second number.");
            string num2 = Console.ReadLine();
            int b = int.Parse(num2);

            int c = a * b;
            Console.WriteLine(num1 + "*" + num2 + "=" + c);

            Console.Write("The resault of multiplying of your numbers is" + " " + c + ".");


        }
    }
}
