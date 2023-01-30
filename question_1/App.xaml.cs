using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_LoginForm.Views;

namespace WPF_LoginForm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void ApplicationMainView(object sender, StartupEventArgs e)
        {
            var mainView = new MainView();
            mainView.Show();
        }
    }
}
