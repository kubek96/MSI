using System.Collections.Generic;
using System.Collections.ObjectModel;
using RoughSet;

namespace MSI.ViewModel
{
    public class RestultsViewModel
    {
        public ObservableCollection<Result> Results
        {
            get { return App.Context.Results; }
        }
    }
}