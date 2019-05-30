using System;
using System.Collections.Generic;

namespace student_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise exerciseOne = new Exercise("Kandy Korner", "React.js");
            Exercise exerciseTwo = new Exercise("Kennels", "React.js");
            Exercise exerciseThird = new Exercise("Urban Planner", "CSharp");
            Exercise exerciseFourth = new Exercise("Daily Journal", "JavaScript");

            Cohort cohortOne = new Cohort("Cohort29");
            Cohort cohorttwo = new Cohort("Cohort30");
            Cohort cohortThird = new Cohort("Cohort31");

            Student Jonathan = new Student("Jonathan", "Schaffer", "@jonizzy");
            Student Jameka = new Student("Jameka", "Echols", "@jameka");
            Student Billy = new Student("Billy", "Mathison", "@billy");
            Student Alex = new Student("Alex", "Thacker", "@alex");

            Jonathan.Cohort = ("Cohort29");
            Jameka.Cohort = ("Cohort30");
            Billy.Cohort = ("Cohort31");
            Alex.Cohort = ("Cohort31");

            Instructor Andy = new Instructor("Andy", "Collins","@andy","Cohort31");
            Instructor Jisie = new Instructor("Jisie", "Collins","@jisie","Cohort29");
            Instructor Steve = new Instructor("Steve", "BrownLee","@steve","Cohort30");

            Andy.AssignExercises(Jonathan, exerciseOne);
            Jisie.AssignExercises(Jameka, exerciseTwo);
            Andy.AssignExercises(Billy, exerciseThird);
            Steve.AssignExercises(Alex, exerciseFourth);

            List<Exercise> exercises = new List<Exercise>(){
                exerciseOne, exerciseTwo, exerciseThird,exerciseFourth
            };
            List<Student> students = new List<Student>(){
                Jonathan, Jameka, Billy, Alex
            };

            foreach (Student student in students) {

                List<string> assignedExercises = new List<string>();

                foreach (Exercise exercise in student.StudentExercises) {
                    assignedExercises.Add(exercise.ExerciseName);
                }
                string exerciseList = String.Join(", ", assignedExercises);
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on the following exercises: {exerciseList}");
            }
        }
    }
}
