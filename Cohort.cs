using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public string Name { get; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public Cohort (string name) {
            Name = name;
        }
    }
}
