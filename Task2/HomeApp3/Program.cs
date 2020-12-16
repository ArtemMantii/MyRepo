using System;

namespace HomeApp3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, I'm a dictionary. I can translate some words about the weather.");

      Boolean readyToExit = false;
      while (!readyToExit)
      {
        string enteredWord = Console.ReadLine();
        switch (enteredWord)
        {
          case "sunny":
            Console.WriteLine("Солнечно");
            break;

          case "cloudy":
            Console.WriteLine("Облачно");
            break;

          case "windy":
            Console.WriteLine("Ветрено");
            break;

          case "hazy":
            Console.WriteLine("Туманно");
            break;

          case "warmly":
            Console.WriteLine("Тепло");
            break;

          case "frosty":
            Console.WriteLine("Холодно");
            break;

          case "rainy":
            Console.WriteLine("Дождливо");
            break;

          case "exit":
            readyToExit = true;
            break;

          default:
            Console.WriteLine("You have entered unknown word!");
            break;

        }

      }
    }
  }
}
