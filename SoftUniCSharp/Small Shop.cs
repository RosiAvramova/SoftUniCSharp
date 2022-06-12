using System;

namespace SmallShop
{
    internal class SmallShop
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double waterPrice = 0;
            double beerPrice = 0;
            double sweetsPrice = 0;
            double peanutsPrice = 0;
            double coffeePrice = 0;
            switch (item)
            {
                case "coffee":
                    if (city == "Sofia") coffeePrice = 0.50;
                    else if (city == "Plovdiv") coffeePrice = 0.40;
                    else if (city == "Varna") coffeePrice = 0.45;
                    Console.WriteLine(coffeePrice * amount);
                    break;
                case "water":
                    if (city == "Sofia") waterPrice = 0.80;
                    else if (city == "Plovdiv") waterPrice = 0.70;
                    else if (city == "Varna") waterPrice = 0.70;
                    Console.WriteLine(waterPrice * amount);
                    break;
                case "beer":
                    if (city == "Sofia") beerPrice = 1.20;
                    else if (city == "Plovdiv") beerPrice = 1.15;
                    else if (city == "Varna") beerPrice = 1.10;
                    Console.WriteLine(beerPrice * amount);

                    break;
                case "sweets":
                    if (city == "Sofia") sweetsPrice = 1.45;
                    else if (city == "Plovdiv") sweetsPrice = 1.30;
                    else if (city == "Varna") sweetsPrice = 1.35;
                    Console.WriteLine(sweetsPrice * amount);

                    break;
                case "peanuts":
                    if (city == "Sofia") peanutsPrice = 1.60;
                    else if (city == "Plovdiv") peanutsPrice = 1.50;
                    else if (city == "Varna") peanutsPrice = 1.55;
                    Console.WriteLine(peanutsPrice * amount);
                    break;


                default:
                    break;
            }
        }
    }
}
