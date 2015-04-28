using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using RoughSet;

namespace MSI.ViewModel
{
    public class UniversumViewModel : INotifyPropertyChanged
    {
        private string _generateNewUniversum;
        private ICommand _generateCommand;

        public UniversumViewModel()
        {
            _generateNewUniversum = "";
            _generateCommand = new DelegateCommand(delegate
            {
                App.Context.GenerateNewUniversum(Convert.ToInt32(_generateNewUniversum));
            });
        }

        public ObservableCollection<Item> Universum
        {
            get { return App.Context.Universum; }
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

        public string GenerateNewUniversum
        {
            get { return _generateNewUniversum; }
            set { SetField(ref _generateNewUniversum, value, "GenerateNewUniversum"); }
        }

        public ICommand GenerateCommand
        {
            get { return _generateCommand; }
        }
    }
}