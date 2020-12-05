using System;

namespace HomeApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buyAlckohol = true;

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
                    adulthood = false;
                    isInputValid = true;
                }

                buyAlckohol = !antibiotics;

                Console.WriteLine("Do you over 21 years old? (YES - 1, NO - 0)");
                string value2 = Console.ReadLine();
                if (value2 == "1")
                {
                    adulthood = true;
                    isInputValid = true;
                }
                else if (value2 == "0")
                {
                    adulthood = false;
                    isInputValid = true;
                }

                buyAlckohol = adulthood;

                Console.WriteLine("Do you have passport? (YES - 1, NO - 0)");
                string value3 = Console.ReadLine();
                if (value3 == "1")
                {
                    passport = true;
                    isInputValid = true;
                }
                else if (value3 == "0") 
                {
                    passport = false;
                    isInputValid = true;
                }

                if (!passport)
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
                    buyAlckohol = passport || driverLicense;
                }

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
                if (!minCash100uah)
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
                    buyAlckohol = minCash100uah || paymentCard;
                }
                Console.WriteLine(buyAlckohol);








            }





        }









    }
    }
