using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
        // public Student (string fName, string lName, string slackHandle, string cohort) {
        //     FirstName = fName;
        //     LastName = lName;
        //     SlackHandle = slackHandle;
        //     Cohort = cohort;
        // }
        public Student (string fName, string lName, string slackHandle) {
            FirstName = fName;
            LastName = lName;
            SlackHandle = slackHandle;
        }
        public Student (string fName, string lName) {
            FirstName = fName;
            LastName = lName;
        }
    }
}
