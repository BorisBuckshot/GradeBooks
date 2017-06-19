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

        public string Description

        { 
            get
            {
                string result;

                switch(LetterGrade)
                {
                    case "A":
                        {
                            result = "Excellent!";
                            break;
                        }

                    case "F":
                        {
                            result = "You fail!";
                            break;
                        }

                    default:
                        {
                            result = "Could be better.";
                            break;
                        }
                }

                return result;
            }
        
                
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (Math.Round(AverageGrade) >= 90)
                {
                    result =  "A";
                }

                else if(Math.Round(AverageGrade) >= 80)
                {
                    result = "B";
                }

                else if(Math.Round(AverageGrade) >= 70)
                {
                    result = "C";
                }

                else if(Math.Round(AverageGrade) >= 60)
                {
                    result = "D";
                }

                else
                {
                    result = "F";
                }

                return result;
            }
        }

        public float AverageGrade, HighestGrade, LowestGrade;



    }
}
