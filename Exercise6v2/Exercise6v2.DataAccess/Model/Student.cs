//using Exercise6v2.ViewModels;

using System.ComponentModel.DataAnnotations;

namespace Exercise6v2.DataAccess.Model
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(int studentId, string firstName, string lastName)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
