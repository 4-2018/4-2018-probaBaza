using System;
using System.Collections.Generic;
using System.Text;

namespace _4_2018_probaBaza
{
    class ExerciseResult
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }
        public int Points  { get; set; }

        public ExerciseResult(int Id, string StudentName, string StudentIndex, int Points)
        {
            this.Id = Id;
            this.StudentName = StudentName;
            this.StudentIndex = StudentIndex;
            this.Points = Points;
        }
    }
}
