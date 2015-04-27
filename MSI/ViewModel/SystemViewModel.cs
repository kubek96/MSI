using System.Collections.Generic;
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