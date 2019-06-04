using System;
using System.Collections.Generic;

namespace student_exercise1
{
    class Exercise
    {
        public Exercise(string exerciseName, string exerciseLanguage)
        {
            ExerciseName = exerciseName;
            ExerciseLanguage = exerciseLanguage;
        }
        public string ExerciseName { get; set; }
        public string ExerciseLanguage { get; set; }

        public List<Student> StudentExercises {get; set;}

    }




}