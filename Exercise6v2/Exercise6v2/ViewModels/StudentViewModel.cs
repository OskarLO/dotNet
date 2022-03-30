using CommunityToolkit.Mvvm.ComponentModel;
using Exercise6v2.Core.Contacts;
using Exercise6v2.Core.Dtos;
using Exercise6v2.Core.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Exercise6v2.ViewModels
{
    public class StudentViewModel : ObservableRecipient
    {

        private readonly IStudentService _studentService;
        private readonly StudentDto _studentDto;

        public StudentViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public StudentViewModel(StudentDto studentDto)
        {
            _studentDto = studentDto;
        }

        public ObservableCollection<StudentViewModel> Students { get; private set; } = new();

        public async void OnNavigatedTo(object parameter)
        {
            if (Students.Count == 0)
            {
                var studentDtos = await _studentService.GetStudentsAsync();

                foreach (var studentDto in studentDtos)
                {
                    Students.Add(new StudentViewModel(studentDto));
                }
                System.Diagnostics.Debug.WriteLine(Students);
            }
        }

        public static explicit operator StudentDto(StudentViewModel c) => new()
        {
            StudentId = c.StudentId,
            FirstName = c.FirstName,
            LastName = c.LastName,
            Subjects = c.Subjects
        };

        public string GetName
        {
            get => FirstName + " " + LastName;
        }


        public int StudentId
        {
            get => _studentDto.StudentId;
        }

        public string FirstName
        {
            get => FirstName;
        }

        public string LastName
        {
            get => _studentDto.LastName;
        }

        public ICollection<SubjectDto> Subjects
        {
            get => _studentDto.Subjects;
        }
    }
}