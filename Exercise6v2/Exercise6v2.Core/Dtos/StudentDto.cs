using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6v2.Core.Dtos
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<SubjectDto> Subjects { get; set; }
    }
}
