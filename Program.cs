using System;
using System.Collections.Generic;
using System.Linq;
using student_exercise1.Data;

namespace student_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            List<Exercise> exercises = repository.GetAllExercises();
            PrintExerciseReport("All Departments", exercises);

            List<Exercise> exByLang = repository.GetExercisesByLanguage("JavaScript");

            Console.WriteLine();
            Console.WriteLine("List of exercises by language (JavaScript is currently passed in):");

            exByLang.ForEach(e => Console.WriteLine($"{e.Id}. {e.ExerciseName}"));

            Console.WriteLine();

            Exercise newExercise = new Exercise
            {
                ExerciseName = "Using ADO.NET",
                ExerciseLanguage = "C#"
            };

            repository.CreateExercise(newExercise);


            Console.WriteLine("List of instructors with their cohort:");

            List<Instructor> instructors = repository.GetInstructorsWithCohort();

            instructors.ForEach(i => Console.WriteLine($"{i.Id}. {i.FirstName} {i.LastName} with {i.Cohort.CohortName}"));


             Console.WriteLine();
            Console.WriteLine("Adding another instructor to the database and assigning a cohort:");

            List<Cohort> cohorts = repository.GetAllCohorts();

            Cohort newCohort = cohorts.First(c => c.CohortName == "Cohort 31");

            Instructor newInstructor = new Instructor
            {
                FirstName = "Toni",
                LastName = "Hart"
            };

            repository.AddInstructorWithCohort(newInstructor, newCohort);


        }
        public static void PrintExerciseReport(string title, List<Exercise> exercises)
            {
            exercises.ForEach(e => Console.WriteLine($"{e.ExerciseName} {e.ExerciseLanguage}"));
            }
    }
}
