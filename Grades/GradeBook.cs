using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public static float MaximumGrade = 100;
        public static float MinimumGrade = 0;
        private List<float> grades;

        public event NameChangedDelegate NameChanged;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }

                    _name = value;
                }
            }

        }

        private string _name;

        public enum Type
        {
            Action,
            Crime,
            Horror,
            Technical
        }

        //public GradeBook(float grade)
        //{
        //    grades.Add(grade);
        //}

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

    }
}
