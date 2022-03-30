﻿using CommunityToolkit.Mvvm.DependencyInjection;

using Exercise6v2.Activation;
using Exercise6v2.Contracts.Services;
using Exercise6v2.Core.Contacts;
using Exercise6v2.Core.Services;
using Exercise6v2.Helpers;
using Exercise6v2.Services;
using Exercise6v2.ViewModels;
using Exercise6v2.Views;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;

// To learn more about WinUI3, see: https://docs.microsoft.com/windows/apps/winui/winui3/.
namespace Exercise6v2
{
    public partial class App : Application
    {
        public static Window MainWindow { get; set; } = new Window() { Title = "AppDisplayName".GetLocalized() };

        public App()
        {
            InitializeComponent();
            UnhandledException += App_UnhandledException;
            Ioc.Default.ConfigureServices(ConfigureServices());
        }

        private void App_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // TODO WTS: Please log and handle the exception as appropriate to your scenario
            // For more info see https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.unhandledexceptioneventargs
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);
            var activationService = Ioc.Default.GetService<IActivationService>();
            await activationService.ActivateAsync(args);
        }

        private System.IServiceProvider ConfigureServices()
        {
            // TODO WTS: Register your services, viewmodels and pages here
            var services = new ServiceCollection();

            // Default Activation Handler
            services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();

            // Other Activation Handlers

            // Services
            services.AddTransient<INavigationViewService, NavigationViewService>();

            services.AddSingleton<IActivationService, ActivationService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // Core Services
            services.AddSingleton<IStudentService, StudentService>();

            // Views and ViewModels
            services.AddTransient<ShellPage>();
            services.AddTransient<ShellViewModel>();
            services.AddTransient<StudentPage>();
            services.AddTransient<SubjectPage>();
            services.AddTransient<StudentViewModel>();
            services.AddTransient<SubjectViewModel>();
            return services.BuildServiceProvider();
        }
    }
}
