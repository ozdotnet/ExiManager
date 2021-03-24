using ExiManager.WPF.States.Navigators;

namespace ExiManager.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
