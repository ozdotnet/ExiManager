using ExiManager.WPF.States.Navigators;
using ExiManager.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace ExiManager.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var viewType = parameter as ViewType?;

            if (viewType != null)
            {
                switch (viewType)
                {
                    case ViewType.FileSystem:
                        _navigator.CurrentViewModel = new FileSystemViewModel();
                        break;
                    case ViewType.Database:
                        _navigator.CurrentViewModel = new DatabaseViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
