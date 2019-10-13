using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradeLimit = int.Parse(Console.ReadLine());
            string taskName = "";
            int taskGrade = 0;
            int badGradeCount = 0;
            int tasksSolvedCount = 0;
            double gradeSum = 0.0;
            string lastTaskName = "";
            bool isEnough = false;

            while (badGradeCount < badGradeLimit)
            {
                taskName = Console.ReadLine();

                if(taskName == "Enough")
                {
                    isEnough = true;
                    break;
                }

                taskGrade = int.Parse(Console.ReadLine());
                tasksSolvedCount++;
                gradeSum += taskGrade;

                if (taskGrade <= 4)
                {
                    badGradeCount++;
                }

                lastTaskName = taskName;
            }

            if(badGradeCount == badGradeLimit)
            {
                Console.WriteLine($"You need a break, {badGradeCount} poor grades.");
            }
            if(isEnough == true)
            {
                double averageScore = gradeSum / tasksSolvedCount;
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {tasksSolvedCount}");
                Console.WriteLine($"Last problem: {lastTaskName}");
            }
        }
    }
}
