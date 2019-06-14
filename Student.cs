using System;
using System.Collections.Generic;

namespace student_exercise1
{
class Student : NSSPeople
{
    public Student(string firstName, string lastName, string slackHandle){
        FirstName = firstName;
        LastName = lastName;
        Slack = slackHandle;
        StudentExercises = new List<Exercise>();
    }
    public string Cohort {get; set;}

    public List<Exercise> StudentExercises {get; set;}
    public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

}




}