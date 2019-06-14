using System;

namespace student_exercise1
{
    public class NSSPeople
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slack { get; set; }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}