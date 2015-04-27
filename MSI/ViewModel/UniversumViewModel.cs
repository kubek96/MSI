using System.Collections.Generic;
using System.ComponentModel;
using RoughSet;

namespace MSI.ViewModel
{
    public class UniversumViewModel : INotifyPropertyChanged
    {
        public List<Item> Universum
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
    }
}