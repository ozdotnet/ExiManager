using ExiManager.WPF.ViewModels;
using System.Windows;

namespace ExiManager.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {            
            var window = new MainWindow();
            window.DataContext = new MainViewModel(); 
            window.Show();

            base.OnStartup(e);
        }
    }
}
