using CommunityToolkit.Mvvm.DependencyInjection;

using Exercise6v2.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Exercise6v2.Views
{
    public sealed partial class AddStudentPage : Page
    {
        public AddStudentViewModel ViewModel { get; }

        public AddStudentPage(AddStudentViewModel viewModel)
        {
            ViewModel = viewModel;

            this.InitializeComponent();
        }
    }
}
