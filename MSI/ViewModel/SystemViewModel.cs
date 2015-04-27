using System.Collections.Generic;
using System.Collections.ObjectModel;
using RoughSet;

namespace MSI.ViewModel
{
    public class SystemViewModel
    {
        public List<Rule> Rules
        {
            get { return App.Context.Rules; }
        }  
    }
}