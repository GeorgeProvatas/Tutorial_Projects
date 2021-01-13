using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of students in class");
            int studentsAmount = int.Parse(Console.ReadLine());

            string[] studentsName = new string[studentsAmount];
            float[] studentsGrade =new float[studentsAmount];

            float highestGrade = 0;
            float gradesSum = 0;

            for(int i = 0; i < studentsAmount; i++)
            {
                Console.WriteLine($"Enter student #{i + 1} name");
                studentsName[i] = Console.ReadLine();

                Console.WriteLine($"Enter student #{i + 1} grade");
                studentsGrade[i] = float.Parse(Console.ReadLine());

                gradesSum += studentsGrade[i];

                if(studentsGrade[i] > highestGrade)
                {
                    highestGrade = studentsGrade[i];
                }

            }

            float averageGrade = gradesSum / studentsAmount;
            Console.WriteLine($"{averageGrade} {highestGrade}");
            
        }
    }
}
