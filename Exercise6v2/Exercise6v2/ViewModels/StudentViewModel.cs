using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Exercise6v2.Contracts.Services;
using Exercise6v2.Contracts.ViewModels;
using Exercise6v2.Core.Contacts;
using Exercise6v2.Core.Dtos;
using Exercise6v2.Core.Services;
using Exercise6v2.Views;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Input;

namespace Exercise6v2.ViewModels
{
    public class StudentViewModel : ObservableRecipient, INavigationAware
    {

        private readonly IStudentService _studentService;
        private readonly INavigationService _navigationService;

        public StudentViewModel(IStudentService studentService, INavigationService navigationService)
        {
            _studentService = studentService;
            _navigationService = navigationService;
        }

        private AddStudentViewModel _selectedStudent;
        public AddStudentViewModel Selected
        {
            get => _selectedStudent;
            set => SetProperty(ref _selectedStudent, value);
            
        }

        public ObservableCollection<AddStudentViewModel> Students { get; set; } = new();

        public async void GetStudents()
        {
            var studentDtos = await _studentService.GetStudentsAsync();

            foreach (var studentDto in studentDtos)
            {
                Students.Add(new AddStudentViewModel(studentDto));
            }
        }

        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(async () =>
                    {
                        AddStudentViewModel newStudent = new();
                        AddStudentPage addStudPage = new(newStudent);

                        ContentDialog dialog = new()
                        {
                            Title = "Add new student",
                            Content = addStudPage,
                            PrimaryButtonText = "Add",
                            IsPrimaryButtonEnabled = false,
                            CloseButtonText = "Cancel",
                            DefaultButton = ContentDialogButton.Primary,
                            XamlRoot = _navigationService.Frame.XamlRoot
                        };

                        newStudent.PropertyChanged += (sender, e) => dialog.IsPrimaryButtonEnabled = !newStudent.HasErrors;

                        ContentDialogResult result = await dialog.ShowAsync();
                        
                        if (result == ContentDialogResult.Primary)
                        {
                            var studentDto = await _studentService.CreateStudentAsync((StudentDto)newStudent);
                            AddStudentViewModel student = new(studentDto);

                            Students.Add(student);
                            Selected = student;
                        }
                    });
                }

                return _addCommand;
            }
        }

        private ICommand _updateCommand;
        public ICommand UpdateCommand 
        {
            get 
            {
                return _updateCommand;
            }
        }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand<AddStudentViewModel>(async param =>
                    {
                        ContentDialog deleteDialog = new()
                        {
                            Title = "Delete student permanently?",
                            Content = "If you delete this student, you won't be able to recover it. Do you want to delete it?",
                            PrimaryButtonText = "Delete",
                            CloseButtonText = "Cancel",
                            DefaultButton = ContentDialogButton.Close,
                            XamlRoot = _navigationService.Frame.XamlRoot
                        };

                        ContentDialogResult result = await deleteDialog.ShowAsync();

                        if (result == ContentDialogResult.Primary)
                        {
                            if (await _studentService.DeleteStudentAsync((StudentDto)param))
                            {
                                _ = Students.Remove(param);
                            }
                        }
                    }, param => param != null);
                }

                return _deleteCommand;
            }
        }

        public void OnNavigatedTo(object parameter)
        {
            
        }

        public void OnNavigatedFrom()
        {
            
        }
    }
}