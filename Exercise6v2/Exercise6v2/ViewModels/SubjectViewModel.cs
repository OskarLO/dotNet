using CommunityToolkit.Mvvm.ComponentModel;
using Exercise6v2.Core.Contacts;
using Exercise6v2.Core.Dtos;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Exercise6v2.ViewModels
{
    public class SubjectViewModel : ObservableRecipient
    {

        private readonly ISubjectService _subjectService;
        private readonly SubjectDto _subjectDto;

        public SubjectViewModel(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public SubjectViewModel(SubjectDto subjectDto)
        {
            _subjectDto = subjectDto;
        }

        public ObservableCollection<SubjectDto> Subjects { get; set; } = new();


        public async void GetSubjects()
        {
            var subjectDtos = await _subjectService.GetSubjectsAsync();

            foreach (var subjectDto in subjectDtos)
            {
                Subjects.Add(subjectDto);
            }
        }


        public ICollection<StudentDto> Students
        {
            get => _subjectDto.Students;
        }
    }   
}
