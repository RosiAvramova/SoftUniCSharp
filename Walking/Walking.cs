using System;

namespace _04Walking
{
    internal class Walking
    {
        static void Main(string[] args)
        {
            int wantedSteps = 10000;
            int totalSteps = 0;
            int stepsOverGoal = 0;
            int stepsToReached = 0;

            while (totalSteps < wantedSteps)
            {
                int steps = 0;
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    steps = int.Parse(input);
                    totalSteps += steps;
                    stepsOverGoal = totalSteps - wantedSteps;
                    stepsToReached = wantedSteps - totalSteps;
                    break;
                }

                steps = int.Parse(input);
                totalSteps += steps;
                stepsOverGoal = totalSteps - wantedSteps;
                stepsToReached = wantedSteps - totalSteps;
            }

            if (wantedSteps <= totalSteps)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsOverGoal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{stepsToReached} more steps to reach goal.");
            }
        }
    }
}
