using System;

namespace _02ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badMarksCounter = 0;
            int maxBadMarks = int.Parse(Console.ReadLine());
            string input = String.Empty;
            double markSum = 0;
            string lastTaskName = String.Empty;
            double taskCounter = 0;
            double average = 0;


            while (input != "Enough")
            {
                input = Console.ReadLine();
                if (input == "Enough" || input == "")
                {
                    break;
                }
                string taskName = input;
                int mark = int.Parse(Console.ReadLine());
                lastTaskName = taskName;
                if (mark > 4)
                {
                    markSum += mark;
                    taskCounter++;

                }
                else
                {
                    badMarksCounter++;
                    markSum += mark;
                    taskCounter++;
                    if (badMarksCounter == maxBadMarks)
                    {
                        Console.WriteLine($"You need a break, {badMarksCounter} poor grades.");

                        return;
                    }
                }

            }


            if (input == "Enough" || input == "")
            {
                average = markSum / taskCounter;

                Console.WriteLine($"Average score: {average:0.00}");
                Console.WriteLine($"Number of problems: {taskCounter}");
                Console.WriteLine($"Last problem: {lastTaskName}");
                return;
            }

        }
    }
}
