﻿using Autofac;
using System.Windows;
using TiToCRM.UI.Data;
using TiToCRM.UI.Startup;
using TiToCRM.UI.ViewModel;

namespace TiToCRM.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            var mainWindow = container.Resolve<MainWindow>();
            MainWindow.Show();
        }
    }
}