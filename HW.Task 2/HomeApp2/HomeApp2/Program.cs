using System;

namespace HomeApp2
{
  class Program
  {
    static bool ReadBoolValueFromConsole(string message, string trueValue, string falseValue)
    {
      while (true)
      {
        OutputQuestion(message, trueValue, falseValue);
        string inputValue = Console.ReadLine();
        if (inputValue.ToLower() == trueValue)
          return true;
        else if (inputValue.ToLower() == falseValue)
          return false;
      }
    }
    static bool ReadBoolValueFromConsole(string message)
    {
      return ReadBoolValueFromConsole(message, "y", "n");
    }

    static int ReadIntValueFromConsole(string message)
    {
      while (true)
      {
        Console.WriteLine(message);
        string inputValue = Console.ReadLine();

        int intValue;
        bool validValue = int.TryParse(inputValue, out intValue);

        if (validValue)
          return intValue;
      }
    }

    static void OutputQuestion(string message, string trueValue, string falseValue)
    {
      Console.WriteLine(message + " (" + trueValue + "/" + falseValue + ")");
    }

    static decimal ReadDecimalFromConsole(string message)
    {
      while (true)
      {
        Console.WriteLine(message);
        string inputValue = Console.ReadLine();

        decimal decValue;
        bool validValue = decimal.TryParse(inputValue, out decValue);

        if (validValue)
          return decValue;
      }
    }

    static void ExitIfFalse(bool condition)
    {
      if (!condition)
      {
        Console.WriteLine("You can't buy alcohol");
        Console.ReadLine();
        Environment.Exit(0);
      }
    }

    static void Main(string[] args)
    {
      bool antibiotics = ReadBoolValueFromConsole("Do you take antibiotics?");
      ExitIfFalse(!antibiotics);

      int age = ReadIntValueFromConsole("How old are you?");
      bool adulthood = age >= 21;
      ExitIfFalse(adulthood);

      bool passport = ReadBoolValueFromConsole("Do you have passport?");
      bool driverLicense = false;
      if (!passport)
        driverLicense = ReadBoolValueFromConsole("Do you have Driver License?");
      ExitIfFalse(passport || driverLicense);

      decimal cash = ReadDecimalFromConsole("How much money you have ?");
      bool minCash100uah = cash >= 100;
      bool paymentCard = false;
      if (!minCash100uah)
        paymentCard = ReadBoolValueFromConsole("Do you have payment card?");
      ExitIfFalse(minCash100uah || paymentCard);

      Console.WriteLine("Congratulations! You can buy alcohol!");
    }
  }
}
