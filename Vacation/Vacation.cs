using System;

namespace Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            using System;

namespace _03.Vacation
    {
        internal class Vacation
        {
            static void Main(string[] args)
            {
                double neededMoney = double.Parse(Console.ReadLine());
                double availableMoney = double.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                double spentMoney = 0;
                double savedMoney = 0;
                int saveDayCounter = 0;
                int spendDayCounter = 0;

                while (true)
                {
                    if (input == "spend")
                    {
                        spentMoney = double.Parse(Console.ReadLine());
                        if (availableMoney - spentMoney < 0)
                        {
                            availableMoney = 0;
                        }
                        else
                        {
                            availableMoney -= spentMoney;
                        }

                        saveDayCounter++;
                        spendDayCounter++;
                    }
                    else if (input == "save")
                    {
                        savedMoney = double.Parse(Console.ReadLine());
                        availableMoney += savedMoney;
                        saveDayCounter++;
                        if (spendDayCounter > 0)
                        {
                            spendDayCounter = 0;
                        }
                    }

                    if (spendDayCounter == 5)
                    {
                        break;
                    }
                    else if (availableMoney >= neededMoney)
                    {
                        break;
                    }

                    input = Console.ReadLine();
                }

                if (availableMoney < neededMoney)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine($"{saveDayCounter}");
                }
                else if (availableMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {saveDayCounter} days.");
                }
            }
        }
    }

}
    }
}
