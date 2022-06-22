using System;

namespace _03NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());
            double result = 0;
            double Roses = 5.00;
            double Dahlias = 3.80;
            double Tulips = 2.80;
            double Narcissus = 3.00;
            double Gladiolus = 2.50;



            double leftMoney = 0;
            double needetMoney = 0;



            if (flowers == "Roses" && numberOfFlowers > 80)
            {
                result = numberOfFlowers * Roses * 0.90;

            }
            else if (flowers == "Roses" && numberOfFlowers <= 80)
            {
                result = numberOfFlowers * Roses;
            }


            if (flowers == "Dahlias" && numberOfFlowers > 90)
            {
                result = numberOfFlowers * Dahlias * 0.85;
            }
            else if (flowers == "Dahlias" && numberOfFlowers <= 90)
            {
                result = numberOfFlowers * Dahlias;
            }

            if (flowers == "Tulips" && numberOfFlowers > 80)
            {
                result = numberOfFlowers * Tulips * 0.85;
            }
            else if (flowers == "Tulips" && numberOfFlowers <= 80)
            {
                result = numberOfFlowers * Tulips;
            }

            else if (flowers == "Narcissus" && numberOfFlowers < 120)
            {
                result = numberOfFlowers * Narcissus * 1.15;
            }
            else if (flowers == "Narcissus" && numberOfFlowers >= 120)
            {
                result = numberOfFlowers * Narcissus;
            }


            if (flowers == "Gladiolus" && numberOfFlowers < 80)

            {
                result = numberOfFlowers * Gladiolus * 1.20;
            }
            else if (flowers == "Gladiolus" && numberOfFlowers >= 80)
            {
                result = numberOfFlowers * Gladiolus;
            }



            if (money >= result)
            {
                leftMoney = money - result;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {leftMoney:0.00} leva left.");
            }
            else if (money < result)
            {
                needetMoney = result - money;
                Console.WriteLine($"Not enough money, you need {needetMoney:0.00} leva more.");
            }
        }
    }
}