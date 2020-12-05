using System;

namespace HomeApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      bool antibiotics = true;

      bool adulthood = true;

      bool passport = true;

      bool driverLicense = true;

      bool minCash100uah = true;

      bool paymentCard = true;

      bool isInputValid = false;
      while (!isInputValid)
      {
        Console.WriteLine("Do you take antibiotics? (YES - 1, NO - 0)");
        string value1 = Console.ReadLine();
        if (value1 == "1")
        {
          antibiotics = true;
          isInputValid = true;
        }
        else if (value1 == "0")
        {
          antibiotics = false;
          isInputValid = true;
        }
      }

      bool buyAlcohol = !antibiotics;

      isInputValid = false;
      while (!isInputValid)
      {
        Console.WriteLine("Do you over 21 years old? (y/n)");
        string value2 = Console.ReadLine();
        if (value2.ToLower() == "y")
        {
          adulthood = true;
          isInputValid = true;
        }
        else if (value2.ToUpper() == "N")
        {
          adulthood = false;
          isInputValid = true;
        }
      }

      buyAlcohol = buyAlcohol && adulthood;

      isInputValid = false;
      while (!isInputValid)
      {
        Console.WriteLine("Do you have passport? (y/n)");
        string value3 = Console.ReadLine();
        if (value3.ToLower() == "y")
        {
          passport = true;
          isInputValid = true;
        }
        else if (value3.ToLower() == "n")
        {
          passport = false;
          isInputValid = true;
        }
      }

      driverLicense = false;
      if (!passport)
      {
        isInputValid = false;
        while (!isInputValid)
        {
          Console.WriteLine("Do you have Driver License? (YES - 1, NO - 0)");
          string value4 = Console.ReadLine();
          if (value4 == "1")
          {
            driverLicense = true;
            isInputValid = true;
          }
          else if (value4 == "0")
          {
            driverLicense = false;
            isInputValid = true;
          }
        }
      }

      buyAlcohol = buyAlcohol && (passport || driverLicense);

      isInputValid = false;
      while (!isInputValid)
      {
        Console.WriteLine("Do you have cash more than 100 UAH? (YES - 1, NO - 0)");
        string value5 = Console.ReadLine();
        if (value5 == "1")
        {
          minCash100uah = true;
          isInputValid = true;
        }
        else if (value5 == "0")
        {
          minCash100uah = false;
          isInputValid = true;
        }
      }

      paymentCard = false;
      if (!minCash100uah)
      {
        isInputValid = false;
        while (!isInputValid)
        {
          Console.WriteLine("Do you have payment card? (YES - 1, NO - 0)");
          string value6 = Console.ReadLine();
          if (value6 == "1")
          {
            paymentCard = true;
            isInputValid = true;
          }
          else if (value6 == "0")
          {
            paymentCard = false;
            isInputValid = true;
          }
        }
      }

      buyAlcohol = buyAlcohol && (minCash100uah || paymentCard);

      Console.WriteLine(buyAlcohol);
    }
  }
}
