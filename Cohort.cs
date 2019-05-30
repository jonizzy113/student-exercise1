using System;
using System.Collections.Generic;

namespace student_exercise1
{
class Cohort {
    public Cohort(string cohortName) {
        CohortName = cohortName;
        StudentList = new List<Student>();
        InstructorList = new List<Instructor>();
    }

    public string CohortName{get; set;}
    public List<Student> StudentList {get; set;}
    public List<Instructor> InstructorList {get; set;}
}




}