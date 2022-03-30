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
        //Task<StudentDto> CreateCharacterAsync(StudentDto student);
        //Task<bool> DeleteCharacterAsync(StudentDto student);
    }
}
