using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        // public Instructor (string fName, string lName, string slackHandle, string cohort) {
        //     FirstName = fName;
        //     LastName = lName;
        //     SlackHandle = slackHandle;
        //     Cohort = cohort;
        // }
        public Instructor (string fName, string lName, string slackHandle) {
            FirstName = fName;
            LastName = lName;
            SlackHandle = slackHandle;
        }
        public Instructor (string fName, string lName) {
            FirstName = fName;
            LastName = lName;
        }
        public void AssignExercise (Exercise exercise, Student student) {
            student.Exercises.Add(exercise);
        }
    }
}
