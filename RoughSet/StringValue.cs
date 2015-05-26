using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughSet
{
    public class StringValue
    {
        public StringValue(string n, string d)
        {
            _name = n;
            _description = d;
        }
        private string _name;
        private string _description;

        public string Nazwa
        {
            get { return _name; }
        }

        public string Opis
        {
            get { return _description; }
        }
    }
}
