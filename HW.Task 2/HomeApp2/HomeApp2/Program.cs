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
      while(true)
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

    static void Main(string[] args)
    {
      bool antibiotics = ReadBoolValueFromConsole("Do you take antibiotics?");
      bool buyAlcohol = !antibiotics;

      int age = ReadIntValueFromConsole("Do you over 21 years old?");
      bool adulthood = age >= 21;
      buyAlcohol = buyAlcohol && adulthood;

      bool passport = ReadBoolValueFromConsole("Do you have passport?");
      bool driverLicense = false;
      if (!passport)
        driverLicense = ReadBoolValueFromConsole("Do you have Driver License?");
      buyAlcohol = buyAlcohol && (passport || driverLicense);

      bool minCash100uah = ReadBoolValueFromConsole("Do you have cash more than 100 UAH ?");
      bool paymentCard = false;
      if (!minCash100uah)
        paymentCard = ReadBoolValueFromConsole("Do you have payment card?");
      buyAlcohol = buyAlcohol && (minCash100uah || paymentCard);

      Console.WriteLine(buyAlcohol);
    }
  }
}
