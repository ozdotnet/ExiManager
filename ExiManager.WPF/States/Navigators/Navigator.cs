using ExiManager.WPF.Commands;
using ExiManager.WPF.ViewModels;
using System.Windows.Input;

namespace ExiManager.WPF.States.Navigators
{
    public class Navigator : INavigator
    {
        public ViewModelBase CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
