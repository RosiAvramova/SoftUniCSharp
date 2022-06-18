using System;

namespace Cake
{
    internal class Cake
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());

            int cakeSize = cakeWidth * cakeHeight;
            
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    break;
                }
                int cakePieces = int.Parse(input);

                cakeSize -= cakePieces;

                if (cakeSize < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                    break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
