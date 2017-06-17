using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeSatistics
    {
        public GradeSatistics()
        {
            HighestGrade = float.MinValue;
            LowestGrade = float.MaxValue;
        }


        public float AverageGrade, HighestGrade, LowestGrade;



    }
}
