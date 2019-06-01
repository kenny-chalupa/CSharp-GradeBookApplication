using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name) {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            char rankedLetter = 'F';
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Gradebook requires 5 Students for Ranked Grades");
                
            }


            return rankedLetter;
        }
    }
}
