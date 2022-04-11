using CommunityToolkit.Mvvm.DependencyInjection;
using Exercise6v2.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace Exercise6v2.Views
{
    public sealed partial class StudentPage : Page
    {
        public StudentViewModel ViewModel { get; }

        public StudentPage()
        {
            ViewModel = Ioc.Default.GetService<StudentViewModel>();
            InitializeComponent();
        }

        private void Button_Click_Get_Students(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.GetStudents();
        }
    }
}
