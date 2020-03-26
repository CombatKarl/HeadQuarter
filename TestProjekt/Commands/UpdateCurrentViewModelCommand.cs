using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestProjekt.State.Navigators;
using TestProjekt.ViewModels;

namespace TestProjekt.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        private readonly InputViewModel _inputViewModel;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;

            _inputViewModel = new InputViewModel();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Input:
                        //_navigator.CurrentViewModel = new InputViewModel();
                        _navigator.CurrentViewModel = _inputViewModel;
                        break;
                    case ViewType.Archiv:
                        _navigator.CurrentViewModel = new ArchivViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}