using RoughSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSI.ViewModel
{
    public class LegendViewModel
    {
        public List<StringValue> Legend
        {
            get { return App.Context.Legend; }
        }  
    }
}
