using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using Exercise6v2.Core.Contacts;
using Exercise6v2.Core.Dtos;

namespace Exercise6v2.ViewModels
{
    public class AddStudentViewModel : ObservableValidator
    {
        private readonly StudentDto _studentDto;

        private readonly List<ValidationResult> _errors = new();
        public string Errors => string.Join(Environment.NewLine, from ValidationResult e in _errors select e.ErrorMessage);
        public new bool HasErrors => Errors.Length > 0;

        public AddStudentViewModel()
        {
            _studentDto = new StudentDto();
            ValidateAllProperties();
            _errors.AddRange(GetErrors());
        }

        public AddStudentViewModel(StudentDto studentDto)
        {
            _studentDto = studentDto;
            ValidateAllProperties();
            _errors.AddRange(GetErrors());
        }

        public static explicit operator StudentDto(AddStudentViewModel c) => new()
        {
            StudentId = c.StudentId,
            FirstName = c.FirstName,
            LastName = c.LastName,
            Subjects = c.Subjects
        };

        public int StudentId
        {
            get => _studentDto.StudentId;
            set => SetProperty(_studentDto.StudentId, value, _studentDto, (_studentDto, id) => _studentDto.StudentId = value);
        }

        public string FirstName
        {
            get => _studentDto.FirstName;
            set => SetProperty(_studentDto.FirstName, value, (firstName) => _studentDto.FirstName = firstName);
        }

        public string LastName
        {
            get => _studentDto.LastName;
            set => SetProperty(_studentDto.LastName, value, (lastName) => _studentDto.LastName = lastName);
        }

        public ICollection<SubjectDto> Subjects
        {
            get => _studentDto.Subjects;
            set => SetProperty(_studentDto.Subjects, value, (subjects) => _studentDto.Subjects = subjects);
        }

        public string StudentInfo 
        {
            get => _studentDto.FirstName + " " + _studentDto.LastName;
        }
    }
}
