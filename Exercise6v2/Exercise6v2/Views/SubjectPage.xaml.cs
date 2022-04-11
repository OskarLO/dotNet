using CommunityToolkit.Mvvm.DependencyInjection;
using Exercise6v2.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace Exercise6v2.Views
{
    public sealed partial class SubjectPage : Page
    {
        public SubjectViewModel ViewModel { get; }

        public SubjectPage()
        {
            ViewModel = Ioc.Default.GetService<SubjectViewModel>();
            InitializeComponent();
        }

        private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.GetSubjects();
        }
    }
}
