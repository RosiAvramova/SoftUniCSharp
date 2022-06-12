using System;

namespace _11._FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double bananaPrice = 0;
            double applePrice = 0;
            double orangePrice = 0;
            double grapefruitPrice = 0;
            double kiwiPrice = 0;
            double pineapplePrice = 0;
            double grapesPrice = 0;


            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    bananaPrice = 2.50;
                    applePrice = 1.20;
                    orangePrice = 0.85;
                    grapefruitPrice = 1.45;
                    kiwiPrice = 2.70;
                    pineapplePrice = 5.50;
                    grapesPrice = 3.85;
                    break;
                case "Saturday":
                case "Sunday":
                    bananaPrice = 2.70;
                    applePrice = 1.25;
                    orangePrice = 0.90;
                    grapefruitPrice = 1.60;
                    kiwiPrice = 3.00;
                    pineapplePrice = 5.60;
                    grapesPrice = 4.20;
                    break;
                default:
                    Console.WriteLine("error");
                    return;

            }

            double price = 0;
            switch (fruit)
            {
                case "banana":
                    price = bananaPrice * count;
                    break;

                case "apple":
                    price = applePrice * count;
                    break;

                case "orange":
                    price = orangePrice * count;
                    break;

                case "grapefruit":
                    price = grapefruitPrice * count;
                    break;

                case "kiwi":
                    price = kiwiPrice * count;
                    break;

                case "pineapple":
                    price = pineapplePrice * count;
                    break;
                case "grapes":
                    price = grapesPrice * count;
                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }

            Console.WriteLine($"{price:0.00}");





        }
    }
}
