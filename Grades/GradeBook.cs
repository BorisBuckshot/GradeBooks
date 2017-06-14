using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public static float MaximumGrade = 100;
        public static float MinimumGrade = 0;


        public GradeBook()
        {

        }

        public GradeBook(float grade)
        {
            grades.Add(grade);
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public void ShowGrade()
        {
            for(int i = 0; i<grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }

        public GradeSatistics ComputeStatistics()
        {
            GradeSatistics stats = new GradeSatistics();


            float sum = 0;
            foreach (float grade in grades)
            {
                //if (grade > stats.HighestGrade) stats.HighestGrade = grade;
                //if (grade < stats.LowestGrade) stats.LowestGrade = grade;

                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void ShowHighestGrade()
        {
            float max = grades[0];

            for(int i =0; i < grades.Count; i++)
            {
                if(grades[i] > max)
                {
                    max = grades[i];
                }
            }
            Console.WriteLine("The highest score is: " + max);

        }

        public void ShowLowestGrade()
        {
            float min = grades[0];

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < min)
                {
                    min = grades[i];
                }

            }
            Console.WriteLine("The lowest score is: " + min);

        }

        public void ShowAverageGrade()
        {
            float average, sum = 0;

            for(int i = 0; i<grades.Count; i++)
            {
                sum += grades[i];
            }

            average = sum / grades.Count;

            Console.WriteLine("The average grade is: " + average);
        }


        List<float> grades = new List<float>();
    }
}
