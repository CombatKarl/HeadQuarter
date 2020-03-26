using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestProjekt.ViewModels;

namespace TestProjekt.State.Navigators
{
    public enum ViewType
    {
        Home,
        Input,
        Archiv
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
