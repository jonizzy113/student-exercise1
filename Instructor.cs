using System;

namespace student_exercise1
{
    class Instructor : NSSPeople
    {
        public Instructor(string firstName, string lastName, string slackHandle, string instructorCohort){
            FirstName = firstName;
            LastName = lastName;
            Slack = slackHandle;
            InstructorCohort = instructorCohort;
    }

    public string InstructorCohort {get; set;}
    public void AssignExercises(Student student, Exercise exercise){
        student.StudentExercises.Add(exercise);
        // exercise.StudentExercises.Add(student);
    }

}




}