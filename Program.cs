using System;
using System.Collections.Generic;
using System.Linq;

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
            Cohort cohortTwo = new Cohort("Cohort30");
            Cohort cohortThird = new Cohort("Cohort31");
            

            Student Jonathan = new Student("Jonathan", "Schaffer", "@jonizzy");
            Student Jameka = new Student("Jameka", "Echols", "@jameka");
            Student Billy = new Student("Billy", "Mathison", "@billy");
            Student Alex = new Student("Alex", "Thacker", "@alex");
            Student Meag = new Student("Meag", "Mueller", "@meag");
            cohortOne.StudentList.Add(Jonathan);
            cohortTwo.StudentList.Add(Jameka);
            cohortTwo.StudentList.Add(Meag);
            cohortThird.StudentList.Add(Billy);
            cohortThird.StudentList.Add(Alex);

            Jonathan.Cohort = ("Cohort29");
            Jameka.Cohort = ("Cohort30");
            Billy.Cohort = ("Cohort31");
            Alex.Cohort = ("Cohort31");
            Meag.Cohort = ("Cohort30");

            Instructor Andy = new Instructor("Andy", "Collins","@andy","Cohort31");
            Instructor Jisie = new Instructor("Jisie", "Collins","@jisie","Cohort29");
            Instructor Steve = new Instructor("Steve", "BrownLee","@steve","Cohort30");

            Andy.AssignExercises(Jonathan, exerciseOne);
            Andy.AssignExercises(Jonathan, exerciseTwo);
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

            // Part 2

                 // Create 4 new lists of students, exercises, cohorts, and instructors

                List<Exercise> exercises2 = new List<Exercise>(){
                exerciseOne, exerciseTwo, exerciseThird,exerciseFourth
            };
                List<Student> students2 = new List<Student>(){
                Jonathan, Jameka, Billy, Alex, Meag
            };

            List<Cohort> Cohort = new List<Cohort>(){
                cohortOne,cohortTwo,cohortThird
            };

            List<Instructor> Instructor = new List<Instructor>(){
                Andy, Jisie, Steve
            };

            // 1. List exercises for the JavaScript language by using the Where() LINQ method.

            IEnumerable<Exercise> JsExercise = exercises2.Where(exer => exer.ExerciseLanguage == "JavaScript");
            Console.WriteLine("- - - - - - - - -");
            Console.WriteLine("List of JavaScript Exercises: ");
            foreach(Exercise exer in JsExercise)
            {
                Console.WriteLine($"{exer.ExerciseName} is a {exer.ExerciseLanguage} exercise");
            }
                Console.WriteLine("- - - - - - - - -");

             // 2. List students in a particular cohort by using the Where() LINQ method.

            IEnumerable<Student> studentC30 = students2.Where(s => s.Cohort == "Cohort30");

            Console.WriteLine("Students in Cohort 30: ");

            foreach(Student s in studentC30)
            {
                Console.WriteLine(s.GetFullName());
            }
            Console.WriteLine("- - - - - - - - -");

            // 3. List instructors in a particular cohort by using the Where() LINQ method.

            IEnumerable<Instructor> instructorsC31 = Instructor.Where(I => I.InstructorCohort == "Cohort31");

            Console.WriteLine("Instructors of Cohort 31: ");

            foreach( Instructor I in instructorsC31) {
                Console.WriteLine(I.FirstName + " " + I.LastName);
            }
            Console.WriteLine("- - - - - - - - -");

             // 4. Sort students by their last name

                Console.WriteLine("Students in order by last name: ");

                IEnumerable<Student> orderedStudent = students2.OrderBy(s => s.LastName);

                foreach(Student s in orderedStudent) {
                    Console.WriteLine(s.GetFullName());
                }

                Console.WriteLine("- - - - - - - - -");

                //  5. Display any students that aren't working on any exercises

                IEnumerable<Student> NoExercises = students2.Where(s => s.StudentExercises.Count == 0);

                    Console.WriteLine("List of students with no exercises: ");

                    foreach(Student s in NoExercises) {
                        Console.WriteLine(s.GetFullName());
                    }

                    Console.WriteLine("- - - - - - - - -");

                // 6. Which student is working on the most exercises

                Student MostExercises = students2.Single(s => s.StudentExercises.Count == students2.Max(student => student.StudentExercises.Count));

                Console.WriteLine("List of students with the most exercises: ");
                Console.WriteLine(MostExercises.GetFullName());
                    Console.WriteLine("- - - - - - - - -");

                    // 7. How many students in each cohort

                    Console.WriteLine("How many students in each cohort");

                    foreach(Cohort cohort in Cohort){
                Console.WriteLine($"{cohort.CohortName} {cohort.StudentList.Count()}");
            }



        }
    }
}
