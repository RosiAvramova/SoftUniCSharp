using System;

namespace _08Graduation
{
    internal class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double mark = double.Parse(Console.ReadLine());
            double result = mark;
            int counter = 1;
            int lowMarks = 0;
            int gradeWithFirstLowMark = 0;
            int gradeWithSecondLowMark = 0;
            while (!(counter == 12))
            {
                if (mark >= 4)
                {
                    mark = double.Parse(Console.ReadLine());
                    result += mark;
                    counter++;
                }
                else
                {
                    lowMarks++;
                    if (lowMarks == 1)
                    {
                        gradeWithFirstLowMark = counter + 1;
                    }
                    if (lowMarks == 2)
                    {
                        gradeWithSecondLowMark = counter + 1;
                        counter--;
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        return;
                    }
                    counter++;
                }


            }
            double averageGrade = result / counter;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:0.00}");
        }
    }
}
