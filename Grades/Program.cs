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
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello! Klaudia is a noob!");
            GradeBook book = new GradeBook();

            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            //book.NameChanged += OnNameChanged2;

            book.Name = "Good Book";
            book.Name = "Book";

            book.AddGrade(91);
            book.AddGrade(89.5f);
            Console.Write("Enter a grade: ");
            float grade2 = float.Parse(Console.ReadLine());
            if (grade2 > GradeBook.MaximumGrade || grade2 < GradeBook.MinimumGrade)
            {
                Console.WriteLine("You've entered an incorrect grade!");
            }
            else
            {
                Console.WriteLine("Ok.");
                book.AddGrade(grade2);
            }

            GradeSatistics stats = book.ComputeStatistics();

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);


            //DateTime date = new DateTime(2017, 6, 17);
            //date.AddDays(1);
            //Console.WriteLine(date);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }


        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
            Console.WriteLine("Method with int");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }

    }
}
