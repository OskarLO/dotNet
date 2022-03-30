using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6v2.Core.Dtos
{
    public class SubjectDto
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public ICollection<StudentDto> Students { get; set; }
    }
}
