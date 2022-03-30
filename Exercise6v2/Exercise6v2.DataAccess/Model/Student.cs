//using Exercise6v2.ViewModels;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercise6v2.DataAccess.Model
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Subject> Subjects { get; set; }

        public Student(int studentId, string firstName, string lastName)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
