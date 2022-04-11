using Exercise6v2.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6v2.Core.Contacts
{
    public interface ISubjectService
    {
        Task<IEnumerable<SubjectDto>> GetSubjectsAsync();
    }
}
