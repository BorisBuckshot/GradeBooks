using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is Bartek Badora.");

            GradeBook book = new GradeBook(100);
            book.AddGrade(91);
            book.AddGrade(89.5f);
            Console.Write("Enter a grade: ");
            float grade2 = float.Parse(Console.ReadLine());
            if(grade2 > GradeBook.MaximumGrade || grade2 < GradeBook.MinimumGrade)
            {
                Console.WriteLine("You've entered an incorrect grade!");
            }
            else
            {
                Console.WriteLine("Ok.");
                book.AddGrade(grade2);
            }

            GradeSatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average grade: " + stats.AverageGrade);
            Console.WriteLine("Highest grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest grade: " + stats.LowestGrade);


        }
    }
}
