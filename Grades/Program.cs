using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook(100);
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.ShowGrade();

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

            GradeBook book2 = book;
            book2.AddGrade(69);

            book2.ShowGrade();

            Console.WriteLine();


            book2.ShowHighestGrade();
            book2.ShowLowestGrade();
            book2.ShowAverageGrade();

        }
    }
}
