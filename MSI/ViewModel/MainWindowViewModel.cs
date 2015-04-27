using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using MSI.View;

namespace MSI.ViewModel
{
    public class MainWindowViewModel
    {
        //private ICommand _universumCommand;
        //private ICommand _rulesCommand;
        //private ICommand _systemCommand;

        public MainWindowViewModel()
        {
            //_universumCommand = new DelegateCommand(delegate { App.Context.MainFrame.Navigate(new UniversumView()); });
            //_rulesCommand = new DelegateCommand(delegate { App.Context.MainFrame.Navigate(new RulesView()); });
        }

        //public ICommand UniversumCommand
        //{
        //    get { return _universumCommand; }
        //}

        //public ICommand RulesCommand
        //{
        //    get { return _rulesCommand; }
        //}

        //public ICommand SystemCommand
        //{
        //    get { return _systemCommand; }
        //}
    }
}