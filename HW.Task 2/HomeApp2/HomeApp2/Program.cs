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

    static decimal ReadDecimalFromConsole (string message)
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

    static void Main(string[] args)
    {
      bool antibiotics = ReadBoolValueFromConsole("Do you take antibiotics?");
      bool buyAlcohol = !antibiotics;
      switch (!antibiotics)
      {
       case true:        
        break;            
       case false:        
        Console.WriteLine("You can't buy alcohol");           
        return;        
      }               

      int age = ReadIntValueFromConsole("How old are you?");
      bool adulthood = age >= 21;
      buyAlcohol = buyAlcohol && adulthood;
      switch (adulthood)
            {
                case true:
                    break;
                case false:
                    Console.WriteLine("You can't buy alcohol");
                    return;
            }

      bool passport = ReadBoolValueFromConsole("Do you have passport?");
      bool driverLicense = false;
      if (!passport)
        driverLicense = ReadBoolValueFromConsole("Do you have Driver License?");
      buyAlcohol = buyAlcohol && (passport || driverLicense);
      switch (passport || driverLicense)
            {
                case true:
                    break;
                case false:
                    Console.WriteLine("You can't buy alcohol");
                    return;
            }

      decimal cash = ReadDecimalFromConsole("How much money you have ?");
      bool minCash100uah = cash >= 100;
      bool paymentCard = false;
      if (!minCash100uah)
        paymentCard = ReadBoolValueFromConsole("Do you have payment card?");
      buyAlcohol = buyAlcohol && (minCash100uah || paymentCard);
      switch (minCash100uah || paymentCard)
            {
                case true:
                    break;
                case false:
                    Console.WriteLine("You can't buy alcohol");
                    return;
            }

            Console.WriteLine(buyAlcohol);
    }
  }
}
