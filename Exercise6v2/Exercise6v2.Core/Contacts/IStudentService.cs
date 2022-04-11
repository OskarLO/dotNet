using Exercise6v2.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6v2.Core.Contacts
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetStudentsAsync();
        Task<StudentDto> CreateStudentAsync(StudentDto student);
        //Task<StudentDto> UpdateStudentAsync(StudentDto student);
        Task<bool> DeleteStudentAsync(StudentDto student);
    }
}
