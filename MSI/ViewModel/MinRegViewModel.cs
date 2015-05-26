using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MSI.ViewModel
{
    public class MinRegViewModel : INotifyPropertyChanged
    {
        private string _generateMinRules;
        private ICommand _generateCommand;

        public MinRegViewModel()
        {
            _generateMinRules = "";
            _generateCommand = new DelegateCommand(delegate
            {
                App.Context.GenerateMinRules();
            });
        }

        public ObservableCollection<MinRule> MinRules
        {
            get { return App.Context.MinRules; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public string GenerateMinRules
        {
            get { return _generateMinRules; }
            set { SetField(ref _generateMinRules, value, "GenerateMinRules"); }
        }

        public ICommand GenerateCommand
        {
            get { return _generateCommand; }
        }
    }
}
