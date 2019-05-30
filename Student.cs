using System;
using System.Collections.Generic;

namespace student_exercise1
{
class Student {
    public Student(string firstName, string lastName, string slackHandle){
        FirstName = firstName;
        LastName = lastName;
        SlackHandle = slackHandle;
        StudentExercises = new List<Exercise>();
    }

    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string SlackHandle {get;set;}
    public string Cohort {get; set;}

    public List<Exercise> StudentExercises {get; set;}

}




}