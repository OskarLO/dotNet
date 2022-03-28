//using Exercise6v2.ViewModels;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercise6v2.DataAccess.Model
{
    public class Subject
    {
        [Required]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public List<Student> Students { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public override string ToString()
        {
            return SubjectName;
        }
    }
}
