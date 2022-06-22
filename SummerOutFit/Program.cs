using System;

namespace _02SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            string outfit = string.Empty;
            string shoes = string.Empty;

            if (10 <= degrees && degrees <= 18)
            {
                if (timeOfTheDay == "Мorning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            if (degrees > 18 && degrees <= 24)
            {
                if (timeOfTheDay == "Мorning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            if (degrees >= 25)
            {
                if (timeOfTheDay == "Мorning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
