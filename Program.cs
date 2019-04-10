using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise kennels = new Exercise("Kennels", "JavaScript");
            Exercise tgs = new Exercise("TGS", "Python");
            Exercise cabs = new Exercise("Cab Dispatcher", "C#");
            Exercise planner = new Exercise("City Planner", "Ruby");

            // Create 3, or more, cohorts.
            Cohort day30 = new Cohort("Day 30");
            Cohort eve7 = new Cohort("Evening 7");
            Cohort day32 = new Cohort("Day 32");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student frank = new Student("Frank", "Rossitano", "worldchamp");
            Student tracy = new Student("Tracy", "Jordan", "imtracyjordan");
            Student jenna = new Student("Jenna", "Maroney", "jennaisastar");
            Student kenneth = new Student("Kenneth", "Parcell", "kennethellen");

            day30.Students.Add(tracy);
            day30.Students.Add(jenna);
            eve7.Students.Add(frank);
            day32.Students.Add(kenneth);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor liz = new Instructor("Elizabeth", "Lemon", "lizlemon");
            Instructor jack = new Instructor("Jack", "Donaghy", "thejacker");
            Instructor pete = new Instructor("Peter", "Hornberger", "fmlpete");

            day30.Instructors.Add(liz);
            day32.Instructors.Add(jack);
            eve7.Instructors.Add(pete);

            // Have each instructor assign 2 exercises to each of the students.

            liz.AssignExercise(tgs, tracy);
            liz.AssignExercise(cabs, tracy);

            liz.AssignExercise(tgs, jenna);
            liz.AssignExercise(cabs, jenna);

            jack.AssignExercise(kennels, kenneth);
            jack.AssignExercise(planner, kenneth);

            pete.AssignExercise(cabs, frank);
            pete.AssignExercise(kennels, frank);

            // CHALLENGE:
            // Create a list of students. Add all of the student instances to it.
            List<Student> students = new List<Student>();
            students.Add(frank);
            students.Add(jenna);
            students.Add(tracy);
            students.Add(kenneth);

            // Create a list of exercises. Add all of the exercise instances to it.
            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(kennels);
            exercises.Add(tgs);
            exercises.Add(cabs);
            exercises.Add(planner);

            // Generate a report that displays which students are working on which exercises.
            foreach (Student student in students)
            {
                Console.WriteLine($@"
{student.FirstName} {student.LastName}
Exercises:");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{exercise.Name}");
                }
            }
        }
    }
}
