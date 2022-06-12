using System;

namespace _12._TradeCommissions
{
    internal class TradeCommissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            switch (town)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 5.0 / 100;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 7.0 / 100;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 8.0 / 100;
                    }
                    else if (sales > 10000)
                    {
                        commission = 12.0 / 100;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 4.5 / 100;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 7.5 / 100;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 10.0 / 100;
                    }
                    else if (sales > 10000)
                    {
                        commission = 13.0 / 100;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 5.5 / 100;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 8.0 / 100;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 12.0 / 100;
                    }
                    else if (sales > 10000)
                    {
                        commission = 14.5 / 100;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;


                default:
                    Console.WriteLine("error");
                    return;
            }
            Console.WriteLine($"{commission * sales:0.00}");
        }
    }
}
