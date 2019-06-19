using System;

namespace student_exercise1
{
     public class Instructor : NSSPeople
    {
        public int Id { get; set; }
    public void AssignExercises(Student student, Exercise exercise){
        student.StudentExercises.Add(exercise);
        // exercise.StudentExercises.Add(student);
    }

}




}