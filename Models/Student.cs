using System;
using System.Collections.Generic;

namespace student_exercise1
{
public class Student : NSSPeople
{

    public List<Exercise> StudentExercises {get; set;}
    public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

}




}