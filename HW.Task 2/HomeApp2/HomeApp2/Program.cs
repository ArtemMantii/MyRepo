using System;

namespace HomeApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you take antibiotics? (YES - 1, NO - 0)");
            string value1 = Console.ReadLine();
            int intValue1 = int.Parse(value1);
            bool antibiotics = intValue1 > 0;

            
            Console.WriteLine("Do you over 21 years old? (YES - 1, NO - 0)");
            string value2 = Console.ReadLine();
            int intValue2 = int.Parse(value2);
            bool adulthood = intValue2 > 0;

            Console.WriteLine("Do you have passport? (YES - 1, NO - 0)");
            string value3 = Console.ReadLine();
            int intValue3 = int.Parse(value3);
            bool passport = intValue3 > 0;

            Console.WriteLine("Do you have Driver License? (YES - 1, NO - 0)");
            string value4 = Console.ReadLine();
            int intValue4 = int.Parse(value4);
            bool driverLicense = intValue4 > 0;

            Console.WriteLine("Do you have cash more than 100 UAH? (YES - 1, NO - 0)");
            string value5 = Console.ReadLine();
            int intValue5 = int.Parse(value5);
            bool minCash100uah = intValue5 > 0;

            Console.WriteLine("Do you have payment card? (YES - 1, NO - 0)");
            string value6 = Console.ReadLine();
            int intValue6 = int.Parse(value6);
            bool paymentCard = intValue6 > 0;

            bool buyAlcohol = !antibiotics && adulthood && (passport || driverLicense) && (minCash100uah || paymentCard);

            Console.WriteLine(buyAlcohol);
            







           // Console.WriteLine("Do you have passport? If you have type 1, if you didn't have type 0");
           // string value2 = Console.ReadLine();
           // int intValue2 = int.Parse(value2);
           //bool passport = intValue2 > 0;
           // passport = true;
           //bool buyAlcohol = adulthood && passport;

            // Console.WriteLine("Buy Alcohol");

        }
    }
}
