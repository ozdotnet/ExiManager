using ExiManager.WPF.ViewModels;
using System.Windows.Input;

namespace ExiManager.WPF.States.Navigators
{
    public enum ViewType
    { 
        FileSystem,
        Database
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }

        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
