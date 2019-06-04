using System;

namespace student_exercise1
{
    class Instructor {
        public Instructor(string firstName, string lastName, string slackHandle, string instructorCohort){
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            InstructorCohort = instructorCohort;
    }

    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string SlackHandle {get; set;}
    public string InstructorCohort {get; set;}
    public void AssignExercises(Student student, Exercise exercise){
        student.StudentExercises.Add(exercise);
        // exercise.StudentExercises.Add(student);
    }

}




}